using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MileStone1_1002284.Models
{
    public class Price
    {
        
        [Key]
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }

      

        public Price()
        {

        }

        public Price(string category,decimal unit_price)
        {
            Category = category;
            UnitPrice = unit_price;
        }

    }
}