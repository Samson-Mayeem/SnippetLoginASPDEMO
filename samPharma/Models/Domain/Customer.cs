using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace samPharma.Models.Domain
{
    public class Customer
    {
        [Key]
        public int Customer_Id { get; set; }
        public string? Customer_Reference { get; set; }
        public string? Customer_Name { get; set; }
        public string? Customer_Address { get; set; }
        public string? Customer_Contact { get; set; }
        public string? Customer_ImageUrl { get; set; }
    }
}