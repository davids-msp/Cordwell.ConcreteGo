using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cordwell.ConcreteGo.ExportTicketsUtility.Models
{
    public class RunData
    {
        public int Id { get; set; }
        public DateTime Order_Date { get; set; }
        public DateTime Ship_Date { get; set; }
        public int Ticket_Number { get; set; }
        public int Plant_Id { get; set; }
        public string PlantDesc { get; set; }
        public int JonelInvNum { get; set; }
        public int Job_ID { get; set; }
        public string Job_Number { get; set; }
        public string Customer_PO_Number { get; set; }
        public string ERP_Customer_Id { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Address1 { get; set; }
        public string Customer_Address2 { get; set; }
        public string Customer_Email { get; set; }
        public string Customer_Number { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Qty { get; set; }
        [Column(TypeName = "decimal(15,2)")]
        public decimal Price { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public bool Prepared_For_Billing_Flag { get; set; }
        public int Status_ID { get; set; }
        public string Product_Number { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Unit_Cost { get; set; }
        public string UOM { get; set; }
        public int Product_Type_ID { get; set; }
        public string ProdDesc { get; set; }
        public bool productValid { get; set; }
        public bool customerValid { get; set; }
        public string Truck_Number { get; set; }
        public bool reviewed { get; set; }
        public int Ticket_Id { get; set; }

        

    }
}
