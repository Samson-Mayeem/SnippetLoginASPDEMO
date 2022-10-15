using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace samPharma.Models.Domain
{
    public class Stock
    {
        [Key]
        public long Drug_Id { get; set; }
        public string? Supplier_Id { get; set; }
        public DateTime Supply_Date { get; set; }
        public decimal Price { get; set; }
        public decimal Tax { get; set; }
        public decimal Quantity { get; set; }
        public decimal Buy_Price { get; set; }
        public decimal Selling_Price { get; set; }
        public string? Current_Invent { get; set; }

    }
}