using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace samPharma.Models.Domain
{
    public class Order
    {
        [Key]
        public long Order_Id { get; set; }
        public string Drug_Id { get; set; }
        public DateTime Order_Date { get; set; }
        public long Quantity { get; set; }
        public decimal Amount_Added { get; set; }
        public decimal Order_Discount { get; set; }
        public string Payment_Mode { get; set; }
        public string Customer_Reference { get; set; }
    }
}