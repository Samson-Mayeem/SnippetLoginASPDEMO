using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace samPharma.Models
{
    public class Order
    {
        public String Order_Id {get; set;}
        public String Drug_Id {get; set;}
        public DateTime Order_Date {get; set;}
        public Int64 Quantity {get; set;}
        public Decimal Amount_Added {get; set;}
        public Decimal Order_Discount {get; set;}
        public String Payment_Mode {get; set;}
        public String Customer_Reference {get; set;}
    }
}