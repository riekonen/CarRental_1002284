using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MileStone1_1002284.Models
{
    public class rentedCar
    {
        public Car cCar { get; set; }
        public decimal rPrice { get; set; }
        public decimal sTotal { get; set; }
        public int rDays { get; set; }

        public rentedCar(Car chosenCar,decimal rentalPrice,decimal subTotal)
        {
            cCar = chosenCar;
            rPrice = rentalPrice;
            sTotal = subTotal;
            rDays = 1;
        }
    }
}