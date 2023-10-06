using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Cordwell.ConcreteGo.API.Connector.Models
{
    [XmlRoot(ElementName = "WebcreteXML")]
    public class RequestCommon<T>
    {
        [XmlElement(ElementName = "WebcreteXMLMsgsRq")]
        public WebcreteXMLMsgsRq<T> WebcreteXMLMsgsRq { get; set; }
    }
    [XmlRoot(ElementName = "WebcreteXMLMsgsRq")]
    public class WebcreteXMLMsgsRq<T>
    {
        //[XmlElement(ElementName = "TicketQueryRq")]
        public T Request { get; set; }
    }
}
