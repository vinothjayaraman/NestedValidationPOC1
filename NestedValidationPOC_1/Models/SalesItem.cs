using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using NestedValidationPOC_1.Validation;

namespace NestedValidationPOC_1.Models
{
    public class SalesItem
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        [SalesItemValidation]
        public int Qty { get; set; }
        public decimal PricePerItem { get; set; }
        public int TotalPrice { get; set; }
    }
}