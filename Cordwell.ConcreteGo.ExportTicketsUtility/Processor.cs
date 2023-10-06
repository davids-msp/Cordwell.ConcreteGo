using Cordwell.ConcreteGo.API.Connector;
using Cordwell.ConcreteGo.API.Connector.Models;
using Cordwell.ConcreteGo.ExportTicketsUtility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cordwell.ConcreteGo.ExportTicketsUtility
{
    public class Processor
    {
        public static async Task<List<RunData>> ConvertCGTicketsToRunData(List<TicketRet> ticketData, CGAPIConnector concreteGoAPI)
        {
            var result = new List<RunData>();
            //var concreteGoAPI = new CGAPIConnector(_CGUser, _CGPass);
            //await concreteGoAPI.LoginAsync();

            if (ticketData != null)
            {
                foreach (var ticket in ticketData)
                {
                    foreach (var product in ticket.Products.Product)
                    {
                        var runItem = new RunData
                        {
                            Ship_Date = (DateTime)ticket.PrintedTime,
                            Ticket_Number = ticket.TicketCode,
                            Ticket_Id = ticket.TicketID,
                            Plant_Id = ticket.PlantCode,
                            PlantDesc = ticket.PlantName,
                            Job_Number = ticket.OrderCode,
                            Job_ID = ticket.OrderID,
                            Customer_PO_Number = ticket.PurchaseOrder,
                            Customer_Name = ticket.CustomerName,
                            Customer_Number = ticket.CustomerCode,
                            Qty = product.PriceQty,
                            Price = product.Price,
                            Address1 = ticket.DeliveryAddr1,
                            Address2 = ticket.DeliveryAddr2,
                            Address3 = ticket.DeliveryAddr3,
                            Prepared_For_Billing_Flag = ticket.Reviewed,
                            Status_ID = ticket.CurrentStatus,
                            Product_Number = product.ItemCode,
                            UOM = product.PriceQtyUnit,
                            Truck_Number = ticket.TruckCode,
                            ProdDesc = product.Description,
                            Order_Date = (DateTime)ticket.OrderDate,
                            reviewed = ticket.Reviewed
                        };

                        if (product.IsMix)
                        {
                            runItem.Product_Type_ID = 1;
                        }
                        else
                        {
                            runItem.Product_Type_ID = 5;
                        }

                        //var custDetails = await concreteGoAPI.GetCustomerByCustomerCode(ticket.CustomerCode);
                        //var returnCustomer = custDetails.WebcreteXMLMsgsRs.CustomerQueryRs.CustomerRet.First();

                        result.Add(runItem);
                    }
                    
                }
                //await concreteGoAPI.LogoutAsync();
                return result;
            }

            return null;

        }
    }
}
