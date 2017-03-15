using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NestedValidationPOC_1.Models
{
    public class SalesOrder
    {
        [Required]
        public int OrderNumber { get; set; }
        [Required]
        public string CustomerName { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public SalesItem[] Items { get; set; }
    }
}