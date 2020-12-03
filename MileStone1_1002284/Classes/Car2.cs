using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MileStone1_1002284.Classes
{

    public class Car2
    {
        public string car_ID { get; set; }
        public int car_int_ID { get; set; }
        public string car_Name { get; set; }
        public string category { get; set; }
        public string description { get; set; }

        public Car2(string c_Id,int c_i_ID,string c_Name,string c_Cat,string c_Des)
        {
            car_ID = c_Id;
            car_int_ID = c_i_ID;
            car_Name = c_Name;
            category = c_Cat;
            description = c_Des;
        }

       
    }
}