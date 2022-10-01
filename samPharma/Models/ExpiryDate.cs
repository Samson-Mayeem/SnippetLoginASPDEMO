using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace samPharma.Models
{
    public class ExpiryDate
    {
        public long Expiry_Id {get; set;}
        public long Drug_Id {get; set;}
        public String? Batch_Number {get; set;}
        public DateTime Manufacture_Date {get; set;}
        public String? Expiry_Date {get; set;}
        public Decimal Quantity {get; set;}
    }
}