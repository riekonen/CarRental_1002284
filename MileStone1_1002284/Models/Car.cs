using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MileStone1_1002284.Models
{
    public class Car
    {
        [Key]
        public string CarID { get; set; }
        [Required]
        [MaxLength(25)]
        public string CarName { get; set; }
        [ForeignKey("Price")]
        [Column(Order = 1)]
        [Required]
        public string Category { get; set; }       
        public virtual Price Price { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        public string imageUrl { get; set; }

       

        public Car()
        {

        }

        public Car(string c_Id, string c_Name, string c_Cat, string c_Des, string c_ImgUrl)
        {
            CarID = c_Id;            
            CarName = c_Name;
            Category = c_Cat;
            Description = c_Des;
            imageUrl = c_ImgUrl;
        }


    }
}