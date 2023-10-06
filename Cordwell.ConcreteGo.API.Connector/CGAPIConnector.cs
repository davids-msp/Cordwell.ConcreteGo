using Cordwell.ConcreteGo.API.Connector.Models;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using System.Xml.Serialization;
using WebcreteAPI;

namespace Cordwell.ConcreteGo.API.Connector
{
    public class CGAPIConnector
    {
        private readonly string _username;
        private readonly string _password;
        private string _appId;
        private string _appKey;
        private string _apiUrl;
        private readonly WebcreteAPISoapClient api = new WebcreteAPISoapClient(new WebcreteAPISoapClient.EndpointConfiguration());
        private TicketHeader _ticketHeader;
        public bool isLoggedIn = false;

        public CGAPIConnector(string appId, string appKey, string username, string password, string apiUrl)
        {
            _appId = appId;
            _appKey = appKey;
            _username = username;
            _password = password;
            _apiUrl = apiUrl;

        }

        #region Authentication

        public async Task LoginAsync()
        {

            api.Endpoint.Address = new EndpointAddress(_apiUrl);
            RSACryptoServiceProvider key = new RSACryptoServiceProvider();
            //Get public key to encrypt password.
            try
            {
                var publicKeyResponse = await api.GetPublicKeyAsync(_appId, _appKey);
                _ticketHeader = publicKeyResponse.TicketHeader;
                key.FromXmlString(publicKeyResponse.GetPublicKeyResult);

            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }

            //Encrypt credentials.
            UnicodeEncoding enc = new UnicodeEncoding();
            var encryptedPassword = key.Encrypt(enc.GetBytes(_password), false);

            //Attempt login.
            try
            {
                var loginResult = await api.LoginAsync(_ticketHeader, _username, encryptedPassword, "");
                if (loginResult.LoginResult)
                {
                    isLoggedIn = true;
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
            isLoggedIn = true;

        }

        public async Task LogoutAsync()
        {

            if (isLoggedIn)
            {
                try
                {
                    var logOutResponse = await api.LogoutAsync(_ticketHeader);
                    if (logOutResponse.LogoutResult)
                    {
                        isLoggedIn = false;
                    }
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException(ex.Message);
                }

            }
        }

        #endregion

        #region Tickets

        public async Task<List<TicketRet>> ListTicketsByDateAsync(DateTime _fromDate, DateTime _toDate)
        {
            //Ensure full date range with times.
            var fromDate = new DateTime(_fromDate.Year, _fromDate.Month, _fromDate.Day);
            var toDate = new DateTime(_toDate.Year, _toDate.Month, _toDate.Day, 23, 59, 59);


            var request = new RequestCommon<TicketQueryRequest>
            {
                WebcreteXMLMsgsRq = new WebcreteXMLMsgsRq<TicketQueryRequest>
                {
                    Request = new TicketQueryRequest
                    {
                        FromTicketTime = fromDate.AddDays(-2),
                        ToTicketTime = toDate.AddDays(2),
                        //IncludeRemovedTicket = true
                        //FromTicketTime = FromDate,
                        //ToTicketTime = ToDate
                        //Reviewed = false
                    }
                }
            };

            var test = Serialize(request);
            test = test.Replace("Request", "TicketQueryRq");
            Console.WriteLine("Request XML:");
            Console.WriteLine(test);

            if (isLoggedIn)
            {
                var rawResponse = await api.ProcessRequestAsync(_ticketHeader, test);

                //var fix = rawResponse.ProcessRequestResult.Replace("/&lt;wbr/&gt;", " wbr ");

                var response = Deserialize<TicketQueryResponse>(rawResponse.ProcessRequestResult);
                var result = response.WebcreteXMLMsgsRs.TicketQueryRs.TicketRet.Where(x => x.CreatedDate >= fromDate && x.CreatedDate <= toDate).ToList();
                //var result = response.WebcreteXMLMsgsRs.TicketQueryRs.TicketRet;
                return result;

            }
            else
            {
                throw new InvalidOperationException("API is not logged in.");
            }
        }

        public async Task<List<TicketRet>> ListTicketsByOrderDateAsync(DateTime _fromDate, DateTime _toDate)
        {
            //Ensure full date range with times.
            var fromDate = new DateTime(_fromDate.Year, _fromDate.Month, _fromDate.Day);
            var toDate = new DateTime(_toDate.Year, _toDate.Month, _toDate.Day, 23, 59, 59);


            var request = new RequestCommon<TicketQueryRequest>
            {
                WebcreteXMLMsgsRq = new WebcreteXMLMsgsRq<TicketQueryRequest>
                {
                    Request = new TicketQueryRequest
                    {
                        FromOrderDate = fromDate.AddDays(-2),
                        ToOrderDate = toDate.AddDays(2)
                        //,
                        //FromTicketTime = FromDate,
                        //ToTicketTime = ToDate
                        //Reviewed = true
                    }
                }
            };



            var test = Serialize(request);
            test = test.Replace("Request", "TicketQueryRq");
            Console.WriteLine("Request XML:");
            Console.WriteLine(test);

            if (isLoggedIn)
            {
                var rawResponse = await api.ProcessRequestAsync(_ticketHeader, test);

                //var fix = rawResponse.ProcessRequestResult.Replace("/&lt;wbr/&gt;", " wbr ");

                var response = Deserialize<TicketQueryResponse>(rawResponse.ProcessRequestResult);
                var result = response.WebcreteXMLMsgsRs.TicketQueryRs.TicketRet.Where(x => x.OrderDate >= fromDate && x.OrderDate <= toDate).ToList();
                //var result = response.WebcreteXMLMsgsRs.TicketQueryRs.TicketRet;
                return result;

            }
            else
            {
                throw new InvalidOperationException("API is not logged in.");
            }



        }

        #endregion

        #region Serialization
        public static string Serialize(object dataToSerialize)
        {
            if (dataToSerialize == null) return null;

            using (StringWriter stringWriter = new System.IO.StringWriter())
            {
                var serializer = new XmlSerializer(dataToSerialize.GetType());

                serializer.Serialize(stringWriter, dataToSerialize);
                return stringWriter.ToString();
            }
        }

        public static T Deserialize<T>(string xmlText)
        {
            var xmlTextAdjusted = FixXmlBool(xmlText);
            //Remove CRLF
            //xmlTextAdjusted = xmlTextAdjusted.Replace("\n", "").Replace("\r", "");
            if (String.IsNullOrWhiteSpace(xmlTextAdjusted)) return default(T);

            using (StringReader stringReader = new System.IO.StringReader(xmlTextAdjusted))
            {
                var serializer = new XmlSerializer(typeof(T));
                //serializer.UnknownNode += new XmlNodeEventHandler(serializer_UnknownNode);
                //serializer.UnknownAttribute += new XmlAttributeEventHandler(serializer_UnknownAttribute);
                try
                {
                    return (T)serializer.Deserialize(stringReader);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

            }
        }

        private static void serializer_UnknownAttribute(object sender, XmlAttributeEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private static void serializer_UnknownNode(object sender, XmlNodeEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        public static string FixXmlBool(string xmlText)
        {
            //ConcreteGoApi annoyingly has uppercase on bool values which disagrees with Deserialize.
            var response = xmlText.Replace("True", "true");
            response = response.Replace("False", "false");

            return response;
        }

        #endregion
    }

    


}