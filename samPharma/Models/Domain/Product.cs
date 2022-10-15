using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace samPharma.Models.Domain
{
    public class Product
    {
        [Key]
        public long Drug_Id { get; set; }
        public string? Drug_Name { get; set; }
        public DateTime Drug_Dosage { get; set; }
        public string? Drug_Type { get; set; }
        public string? Drug_ImageUrl { get; set; }
    }
}