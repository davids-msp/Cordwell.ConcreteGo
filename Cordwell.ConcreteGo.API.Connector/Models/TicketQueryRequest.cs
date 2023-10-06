using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Cordwell.ConcreteGo.API.Connector.Models
{
    public class TicketQueryRequest
    {
        public DateTime? FromOrderDate { get; set; }
        public bool ShouldSerializeFromOrderDate()
        {
            return FromOrderDate.HasValue;
        }
        public DateTime? ToOrderDate { get; set; }
        public bool ShouldSerializeToOrderDate()
        {
            return ToOrderDate.HasValue;
        }
        public DateTime? FromTicketTime { get; set; }
        public bool ShouldSerializeFromTicketTime()
        {
            return FromTicketTime.HasValue;
        }
        public DateTime? ToTicketTime { get; set; }
        public bool ShouldSerializeToTicketTime()
        {
            return ToTicketTime.HasValue;
        }
        public DateTime? FromUpdateTime { get; set; }
        public bool ShouldSerializeFromUpdateTime()
        {
            return FromUpdateTime.HasValue;
        }
        public DateTime? ToUpdateTime { get; set; }
        public bool ShouldSerializeToUpdateTime()
        {
            return ToUpdateTime.HasValue;
        }
        public DateTime? FromLoadTime { get; set; }
        public bool ShouldSerializeFromLoadTime()
        {
            return FromLoadTime.HasValue;
        }
        public DateTime? ToLoadTime { get; set; }
        public bool ShouldSerializeToLoadTime()
        {
            return ToLoadTime.HasValue;
        }
        public string OrderID { get; set; }
        public bool ShouldSerializeOrderID()
        {
            return !String.IsNullOrEmpty(OrderID);
        }
        //public string OrderCode { get; set; }
        //public bool ShouldSerializeOrderCode()
        //{
        //    return !String.IsNullOrEmpty(OrderCode);
        //}
        public string TicketID { get; set; }
        public bool ShouldSerializeTicketID()
        {
            return !String.IsNullOrEmpty(TicketID);
        }
        public string TicketCode { get; set; }
        public bool ShouldSerializeTicketCode()
        {
            return !String.IsNullOrEmpty(TicketCode);
        }
        public string PlantCode { get; set; }
        public bool ShouldSerializPlantCode()
        {
            return !String.IsNullOrEmpty(PlantCode);
        }
        public string CustomerCode { get; set; }
        public bool ShouldSerializeCustomerCode()
        {
            return !String.IsNullOrEmpty(CustomerCode);
        }
        public string ListOnly { get; set; }
        public bool ShouldSerializeListOnly()
        {
            return !String.IsNullOrEmpty(ListOnly);
        }
        //public bool? Reviewed { get; set; }
        //public bool ShouldSerializeReviewed()
        //{
        //    return Reviewed.HasValue;
        //}

        public bool IncludeRemovedTicket { get; set; }
        public bool ShouldSerializeIncludeRemovedTicket()
        {
            return IncludeRemovedTicket;
        }

    }
}
