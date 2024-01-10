using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Innvoice_Services.Models
{

 
    [DataContract]
    public class Invoice
    {

        [DataMember]
        public String InvoiceNo { get; set; }
        [DataMember]
        public String CustumerNo { get; set; }
        [DataMember]
        public DateTime? InvoiceDate { get; set; }
        [DataMember]
        public String OrderDate { get; set; }
        [DataMember]
        public String SONumber { get; set; }
        [DataMember]
        public String OrderedBy { get; set; }
        [DataMember]
        public String CustumerPONumber { get; set; }
        [DataMember]
        public String Paymentmethod { get; set; }
        [DataMember]
        public String Warehouse { get; set; }
        [DataMember]
        public String FOB { get; set; }
        [DataMember]
        public String SalesPerson { get; set; }
        [DataMember]
        public String ResaleNumber { get; set; }
        [DataMember]
        public float? OrderQuantity { get; set; }
        [DataMember]
        public float? ShipQuantity { get; set; }
        [DataMember]
        public String Tax { get; set; }
        [DataMember]
        public String ItemNumber { get; set; }
        [DataMember]
        public Double? UnitPrice { get; set; }
        [DataMember]
        public Double? ExtendedPrice { get; set; }
        [DataMember]
        public String ShipVia { get; set; }

        public Invoice(
        string invoiceNo,
        string custumerNo,
        DateTime? invoiceDate,
         string orderDate,
     string soNumber,
    String orderedBy,
      string custumerPONumber,
     string paymentMethod,
    string warehouse,
    string fob,
    string salesPerson,
       string resaleNumber,
      float? orderQuantity,
    float? shipQuantity,
   string tax,
     string itemNumber,
      Double? unitPrice,
     Double? extendedPrice,
     String shipvia
    )
        {
            InvoiceNo = invoiceNo;
            CustumerNo = custumerNo;
            InvoiceDate = invoiceDate;
            OrderDate = orderDate;
               SONumber = soNumber;
            OrderedBy = orderedBy;
             CustumerPONumber = custumerPONumber;
             Paymentmethod = paymentMethod;
             Warehouse = warehouse;
              FOB = fob;
            SalesPerson = salesPerson;
           ResaleNumber = resaleNumber;
             OrderQuantity = orderQuantity;
            ShipQuantity = shipQuantity;
           Tax = tax;
            ItemNumber = itemNumber;
             UnitPrice = unitPrice;
              ExtendedPrice =extendedPrice;
            ShipVia = shipvia;
        }
        private double? ConvertToNullableDouble(string input)
        {
            if (double.TryParse(input, out double result))
            {
                return result;
            }
            return null;
        }


    }
}