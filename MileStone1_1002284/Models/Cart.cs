using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MileStone1_1002284.Models
{
    public class Cart
    {
        [Key]
        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string Id { get; set; }        
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Key]
        [ForeignKey("Car")]
        [Column(Order =2)]
        public string CarID { get; set; }
        public virtual Car Car { get; set; }
        //  [Key]
        //  [ForeignKey("User")]
        //  [Column(Order =2)]
        //   public string UserName { get; set; }
        //   public virtual User User { get; set; }


        
       

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal SubTotal { get; set; }


        public Cart(string userId,string carID,DateTime sDate,DateTime eDate, decimal sTotal)
        {
            Id = userId;
            CarID = carID;
            StartDate = sDate;
            EndDate = eDate;
            SubTotal = sTotal;
        }

        public Cart()
        {

        }
    }


}