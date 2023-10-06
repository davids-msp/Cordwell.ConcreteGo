using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Cordwell.ConcreteGo.API.Connector.Models
{
    [XmlRoot(ElementName = "Product")]
    public class Product
    {

        [XmlElement(ElementName = "ProductID")]
        public int ProductID { get; set; }

        [XmlElement(ElementName = "ItemID")]
        public int ItemID { get; set; }

        [XmlElement(ElementName = "ItemCode")]
        public string ItemCode { get; set; }

        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "ShortDescription")]
        public string ShortDescription { get; set; }

        [XmlElement(ElementName = "IsMix")]
        public bool IsMix { get; set; }

        [XmlElement(ElementName = "IsAssoc")]
        public bool IsAssoc { get; set; }

        [XmlElement(ElementName = "ChargeType")]
        public int ChargeType { get; set; }

        [XmlElement(ElementName = "Price")]
        public decimal Price { get; set; }

        [XmlElement(ElementName = "PriceUnit")]
        public string PriceUnit { get; set; }

        [XmlElement(ElementName = "OrderQty")]
        public string _OrderQty { get; set; }

        [XmlIgnore]
        public double? OrderQty
        {
            get
            {
                double value;
                if (double.TryParse(_OrderQty, out value))
                {
                    return value;
                }
                return null;
            }
        }


        [XmlElement(ElementName = "OrderQtyUnit")]
        public string OrderQtyUnit { get; set; }

        [XmlElement(ElementName = "LoadQty")]
        public string _LoadQty { get; set; }

        [XmlIgnore]
        public double? LoadQty
        {
            get
            {
                double value;
                if (double.TryParse(_LoadQty, out value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "DelvQty")]
        public decimal DelvQty { get; set; }

        [XmlElement(ElementName = "DelvQtyUnit")]
        public string DelvQtyUnit { get; set; }

        [XmlElement(ElementName = "AccDelvQty")]
        public string _AccDelvQty { get; set; }

        [XmlIgnore]
        public double? AccDelvQty
        {
            get
            {
                double value;
                if (double.TryParse(_AccDelvQty, out value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "PreQty")]
        public string _PreQty { get; set; }

        [XmlIgnore]
        public double? PreQty
        {
            get
            {
                double value;
                if (double.TryParse(_PreQty, out value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "TicketQty")]
        public string _TicketQty { get; set; }

        [XmlIgnore]
        public decimal? TicketQty
        {
            get
            {
                decimal value;
                if (decimal.TryParse(_TicketQty, out value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "TicketQtyUnit")]
        public string TicketQtyUnit { get; set; }

        [XmlElement(ElementName = "PriceQty")]
        public decimal PriceQty { get; set; }

        [XmlElement(ElementName = "PriceQtyUnit")]
        public string PriceQtyUnit { get; set; }

        [XmlElement(ElementName = "Slump")]
        public string _Slump { get; set; }

        [XmlIgnore]
        public int? Slump
        {
            get
            {
                int value;
                if (int.TryParse(_Slump, out value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "TrimPercent")]
        public string _TrimPercent { get; set; }

        [XmlIgnore]
        public double? TrimPercent
        {
            get
            {
                double value;
                if (double.TryParse(_TrimPercent, out value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "TradeDiscountable")]
        public bool TradeDiscountable { get; set; }

        [XmlElement(ElementName = "Taxable")]
        public string Taxable { get; set; }

        [XmlElement(ElementName = "Tax1")]
        public double Tax1 { get; set; }

        [XmlElement(ElementName = "Tax2")]
        public double Tax2 { get; set; }

        [XmlElement(ElementName = "Tax3")]
        public double Tax3 { get; set; }

        [XmlElement(ElementName = "Tax4")]
        public double Tax4 { get; set; }

        [XmlElement(ElementName = "Tax5")]
        public double Tax5 { get; set; }

        [XmlElement(ElementName = "TaxAmount")]
        public double TaxAmount { get; set; }

        [XmlElement(ElementName = "Amount")]
        public double Amount { get; set; }

        [XmlElement(ElementName = "AccountLinkCode")]
        public string AccountLinkCode { get; set; }
    }

    [XmlRoot(ElementName = "Products")]
    public class Products
    {

        [XmlElement(ElementName = "Product")]
        public List<Product> Product { get; set; }
    }

    [XmlRoot(ElementName = "BatchResult")]
    public class BatchResult
    {

        [XmlElement(ElementName = "BatchWeight")]
        public BatchWeight BatchWeight { get; set; }
    }

    [XmlRoot(ElementName = "TicketRet")]
    public class TicketRet
    {

        [XmlElement(ElementName = "TicketID")]
        public int TicketID { get; set; }

        [XmlElement(ElementName = "CreatedDate")]
        public string _CreatedDate { get; set; }

        [XmlIgnore]
        public DateTime? CreatedDate
        {
            get
            {
                DateTime dt;
                if (DateTime.TryParse(_CreatedDate, out dt))
                {
                    return dt;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "PlantCode")]
        public string PlantCode { get; set; }

        [XmlElement(ElementName = "PlantName")]
        public string PlantName { get; set; }

        [XmlElement(ElementName = "PricingPlantCode")]
        public string PricingPlantCode { get; set; }

        [XmlElement(ElementName = "TicketCode")]
        public int TicketCode { get; set; }

        [XmlElement(ElementName = "OrderDate")]
        public string _OrderDate { get; set; }

        [XmlIgnore]
        public DateTime? OrderDate
        {
            get
            {
                DateTime dt;
                if (DateTime.TryParse(_OrderDate, out dt))
                {
                    return dt;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "OrderID")]
        public int OrderID { get; set; }

        [XmlElement(ElementName = "OrderCode")]
        public string OrderCode { get; set; }

        [XmlElement(ElementName = "MixCode")]
        public string MixCode { get; set; }

        [XmlElement(ElementName = "CurrentStatus")]
        public int CurrentStatus { get; set; }

        [XmlElement(ElementName = "PaymentForm")]
        public int PaymentForm { get; set; }

        [XmlElement(ElementName = "TruckCode")]
        public string TruckCode { get; set; }

        [XmlElement(ElementName = "DriverCode")]
        public string DriverCode { get; set; }

        [XmlElement(ElementName = "DriverName")]
        public string DriverName { get; set; }

        [XmlElement(ElementName = "CustomerCode")]
        public string CustomerCode { get; set; }

        [XmlElement(ElementName = "CustomerName")]
        public string CustomerName { get; set; }

        [XmlElement(ElementName = "CustomerDivisionCode")]
        public string CustomerDivisionCode { get; set; }

        [XmlElement(ElementName = "CustomerJob")]
        public string CustomerJob { get; set; }

        [XmlElement(ElementName = "ProjectCode")]
        public string ProjectCode { get; set; }

        [XmlElement(ElementName = "ProjectName")]
        public string ProjectName { get; set; }

        [XmlElement(ElementName = "LotBlockNumber")]
        public string LotBlockNumber { get; set; }

        [XmlElement(ElementName = "PurchaseOrder")]
        public string PurchaseOrder { get; set; }

        [XmlElement(ElementName = "PocketNumber")]
        public string PocketNumber { get; set; }

        [XmlElement(ElementName = "JobNumber")]
        public string JobNumber { get; set; }

        [XmlElement(ElementName = "DeliveryAddr1")]
        public string DeliveryAddr1 { get; set; }

        [XmlElement(ElementName = "DeliveryAddr2")]
        public string DeliveryAddr2 { get; set; }

        [XmlElement(ElementName = "DeliveryAddr3")]
        public string DeliveryAddr3 { get; set; }

        [XmlElement(ElementName = "InstructionAddr1")]
        public string InstructionAddr1 { get; set; }

        [XmlElement(ElementName = "InstructionAddr2")]
        public string InstructionAddr2 { get; set; }

        [XmlElement(ElementName = "InstructionAddr3")]
        public string InstructionAddr3 { get; set; }

        [XmlElement(ElementName = "InstructionAddr4")]
        public string InstructionAddr4 { get; set; }

        [XmlElement(ElementName = "InstructionAddr5")]
        public string InstructionAddr5 { get; set; }

        [XmlElement(ElementName = "InstructionAddr6")]
        public string InstructionAddr6 { get; set; }

        [XmlElement(ElementName = "ZoneCode")]
        public string ZoneCode { get; set; }

        [XmlElement(ElementName = "ZoneName")]
        public string ZoneName { get; set; }

        [XmlElement(ElementName = "RemoveReasonCode")]
        public string RemoveReasonCode { get; set; }

        [XmlElement(ElementName = "TaxCode")]
        public string TaxCode { get; set; }

        [XmlElement(ElementName = "TaxCodeDescription")]
        public string TaxCodeDescription { get; set; }

        [XmlElement(ElementName = "TaxCodeShortDescription")]
        public string TaxCodeShortDescription { get; set; }

        [XmlElement(ElementName = "Taxable")]
        public string Taxable { get; set; }

        [XmlElement(ElementName = "NonTaxableReasonCode")]
        public string NonTaxableReasonCode { get; set; }

        [XmlElement(ElementName = "NonTaxableReasonShortDescription")]
        public string NonTaxableReasonShortDescription { get; set; }

        [XmlElement(ElementName = "HaulerCode")]
        public string HaulerCode { get; set; }

        [XmlElement(ElementName = "HaulerName")]
        public string HaulerName { get; set; }

        [XmlElement(ElementName = "UsageCode")]
        public string UsageCode { get; set; }

        [XmlElement(ElementName = "UsageShort")]
        public string UsageShort { get; set; }

        [XmlElement(ElementName = "WeightMasterCode")]
        public string WeightMasterCode { get; set; }

        [XmlElement(ElementName = "WeightMasterName")]
        public string WeightMasterName { get; set; }

        [XmlElement(ElementName = "WaterAddedOnJob")]
        public string _WaterAddedOnJob { get; set; }
        [XmlIgnore]
        public double? WaterAddedOnJob
        {
            get
            {
                double wt = 0;
                if (double.TryParse(_WaterAddedOnJob, out wt))
                {
                    return wt;
                }
                else
                {
                    return null;
                }
            }
        }

        [XmlElement(ElementName = "QBInvoiceEmailChecked")]
        public bool QBInvoiceEmailChecked { get; set; }

        [XmlElement(ElementName = "ScheduledOnJobTime")]
        public string _ScheduledOnJobTime { get; set; }

        [XmlIgnore]
        public DateTime? ScheduledOnJobTime
        {
            get
            {
                DateTime dt;
                if (DateTime.TryParse(_ScheduledOnJobTime, out dt))
                {
                    return dt;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "PrintedTime")]
        public string _PrintedTime { get; set; }

        [XmlIgnore]
        public DateTime? PrintedTime
        {
            get
            {
                DateTime dt;
                if (DateTime.TryParse(_PrintedTime, out dt))
                {
                    return dt;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "LoadTime")]
        public string _LoadTime { get; set; }

        [XmlIgnore]
        public DateTime? LoadTime
        {
            get
            {
                DateTime dt;
                if (DateTime.TryParse(_LoadTime, out dt))
                {
                    return dt;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "ToJobTime")]
        public string _ToJobTime { get; set; }

        [XmlIgnore]
        public DateTime? ToJobTime
        {
            get
            {
                DateTime dt;
                if (DateTime.TryParse(_ToJobTime, out dt))
                {
                    return dt;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "OnJobTime")]
        public string _OnJobTime { get; set; }

        [XmlIgnore]
        public DateTime? OnJobTime
        {
            get
            {
                DateTime dt;
                if (DateTime.TryParse(_OnJobTime, out dt))
                {
                    return dt;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "UnloadTime")]
        public string _UnloadTime { get; set; }

        [XmlIgnore]
        public DateTime? UnloadTime
        {
            get
            {
                DateTime dt;
                if (DateTime.TryParse(_UnloadTime, out dt))
                {
                    return dt;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "EndUnload")]
        public string _EndUnload { get; set; }
        [XmlIgnore]
        public DateTime? EndUnload
        {
            get
            {
                DateTime dt;
                if (DateTime.TryParse(_EndUnload, out dt))
                {
                    return dt;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "WashTime")]
        public string _WashTime { get; set; }

        [XmlIgnore]
        public DateTime? WashTime
        {
            get
            {
                DateTime dt;
                if (DateTime.TryParse(_WashTime, out dt))
                {
                    return dt;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "ToPlantTime")]
        public string _ToPlantTime { get; set; }

        [XmlIgnore]
        public DateTime? ToPlantTime
        {
            get
            {
                DateTime dt;
                if (DateTime.TryParse(_ToPlantTime, out dt))
                {
                    return dt;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "AtPlantTime")]
        public string _AtPlantTime { get; set; }

        [XmlIgnore]
        public DateTime? AtPlanttime
        {
            get
            {
                DateTime dt;
                if (DateTime.TryParse(_AtPlantTime, out dt))
                {
                    return dt;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "Active")]
        public int Active { get; set; }

        [XmlElement(ElementName = "Amount")]
        public string _Amount { get; set; }
        [XmlIgnore]
        public decimal? Amount
        {
            get
            {
                decimal value;
                if (decimal.TryParse(_Amount, out value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "TotalAmount")]
        public string _TotalAmount { get; set; }
        [XmlIgnore]
        public decimal? TotalAmount
        {
            get
            {
                decimal value;
                if (decimal.TryParse(_TotalAmount, out value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "TaxAmount")]
        public string _TaxAmount { get; set; }
        [XmlIgnore]
        public double? TaxAmount
        {
            get
            {
                double value;
                if (double.TryParse(_TaxAmount, out value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "TradeDiscountPercent")]
        public double TradeDiscountPercent { get; set; }

        [XmlElement(ElementName = "TradeDiscountAmount")]
        public decimal TradeDiscountAmount { get; set; }

        [XmlElement(ElementName = "TaxExemptID1")]
        public object TaxExemptID1 { get; set; }

        [XmlElement(ElementName = "BuildingPermit")]
        public object BuildingPermit { get; set; }

        [XmlElement(ElementName = "ScheduleDistance")]
        public double ScheduleDistance { get; set; }

        [XmlElement(ElementName = "Removed")]
        public bool Removed { get; set; }

        [XmlElement(ElementName = "PrintMixWeight")]
        public bool PrintMixWeight { get; set; }

        [XmlElement(ElementName = "PaymentTermsCode")]
        public string PaymentTermsCode { get; set; }

        [XmlElement(ElementName = "PaymentTermsName")]
        public object PaymentTermsName { get; set; }

        [XmlElement(ElementName = "SalesmanID")]
        public int SalesmanID { get; set; }

        [XmlElement(ElementName = "SalesmanCode")]
        public string SalesmanCode { get; set; }

        [XmlElement(ElementName = "SalesmanName")]
        public string SalesmanName { get; set; }

        [XmlElement(ElementName = "SalesAnalysisCode")]
        public string SalesAnalysisCode { get; set; }

        [XmlElement(ElementName = "SchedulingTruckTypeCode")]
        public string SchedulingTruckTypeCode { get; set; }

        [XmlElement(ElementName = "UpdateTime")]
        public string _UpdateTime { get; set; }

        [XmlIgnore]
        public DateTime? UpdateTime
        {
            get
            {
                DateTime dt;
                if (DateTime.TryParse(_UpdateTime, out dt))
                {
                    return dt;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "Reviewed")]
        public bool Reviewed { get; set; }

        [XmlElement(ElementName = "Products")]
        public Products Products { get; set; }

        [XmlElement(ElementName = "BatchResult")]
        public BatchResult BatchResult { get; set; }
    }

    [XmlRoot(ElementName = "Material")]
    public class Material
    {

        [XmlElement(ElementName = "ItemID")]
        public string _ItemID { get; set; }

        [XmlIgnore]
        public int? ItemId
        {
            get
            {
                int id;
                if (int.TryParse(_ItemID, out id))
                {
                    return id;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "ItemCode")]
        public string ItemCode { get; set; }

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "BatchTarget")]
        public double BatchTarget { get; set; }

        [XmlElement(ElementName = "BatchActual")]
        public double BatchActual { get; set; }

        [XmlElement(ElementName = "BatchUnit")]
        public string BatchUnit { get; set; }

        [XmlElement(ElementName = "MoisturePercent")]
        public double MoisturePercent { get; set; }
    }

    [XmlRoot(ElementName = "BatchWeight")]
    public class BatchWeight
    {

        [XmlElement(ElementName = "Material")]
        public List<Material> Material { get; set; }
    }

    [XmlRoot(ElementName = "TicketQueryRs")]
    public class TicketQueryRs
    {

        [XmlElement(ElementName = "TicketRet")]
        public List<TicketRet> TicketRet { get; set; }

        [XmlAttribute(AttributeName = "statusCode")]
        public string StatusCode { get; set; }

        [XmlAttribute(AttributeName = "statusSeverity")]
        public string StatusSeverity { get; set; }

        [XmlAttribute(AttributeName = "statusMessage")]
        public string StatusMessage { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "WebcreteXMLMsgsRs")]
    public class WebcreteXMLMsgsRs
    {

        [XmlElement(ElementName = "TicketQueryRs")]
        public TicketQueryRs TicketQueryRs { get; set; }
    }


    [XmlRoot(ElementName = "WebcreteXML")]
    public class TicketQueryResponse
    {

        [XmlElement(ElementName = "WebcreteXMLMsgsRs")]
        public WebcreteXMLMsgsRs WebcreteXMLMsgsRs { get; set; }
    }
}
