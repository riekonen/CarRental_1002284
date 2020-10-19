using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MileStone1_1002284.Classes;

namespace MileStone1_1002284
{
    
    public partial class WebForm2 : System.Web.UI.Page
    {
        List<Button> cartBtns = new List<Button>();
        List<DropDownList> ddl_Days = new List<DropDownList>();
        List<Label> cartLabels = new List<Label>();
        List<Car> cars = new List<Car>();
        List<int> daysList = new List<int>();
        List<rentedCar> shoppingCart = new List<rentedCar>();
        rentedCar rCar;
        Car tempCar;
        int maxNumDays = 5;
        decimal price=0;
        decimal subTotal=0;
        string car_Category = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
               // Session["chosenCarsSession"] = shoppingCart;

                for (int x = 0; x < maxNumDays; x++)
                {
                    daysList.Add(x + 1);
                }
                Car honda = new Car("LXHC01",0, "Honda Civic", "Luxury", "It nice!");
                Car toyota = new Car("PMTX01",1, "Toyota Mark X", "Premium", "It nice bad!");
                Car toyota2 = new Car("SDTA01",2, "Toyota Axio", "Standard", "It very nice!");

                cars.Add(honda);
                cars.Add(toyota);
                cars.Add(toyota2);

            if (!IsPostBack)
            {
                ddl_DaysRented01.DataSource = daysList;
                ddl_DaysRented02.DataSource = daysList;
                ddl_DaysRented03.DataSource = daysList;


                ddl_DaysRented01.DataBind();
                ddl_DaysRented02.DataBind();
                ddl_DaysRented03.DataBind();
            }

                
            SetCartDefaults();


        }

        protected void btn_AddCart01_Click(object sender, EventArgs e)
        {
            int btn_int_ID = 0;
            int days_Rented = Convert.ToInt32(ddl_DaysRented01.SelectedItem.Value);
            getCar(btn_int_ID, days_Rented);           
        }
        protected void btn_AddCart02_Click(object sender, EventArgs e)
        {
            int btn_int_ID = 1;
            int days_Rented = Convert.ToInt32(ddl_DaysRented02.SelectedItem.Value);
            getCar(btn_int_ID, days_Rented);
        }

        protected void btn_AddCart03_Click(object sender, EventArgs e)
        {
            int btn_int_ID = 2;
            int days_Rented = Convert.ToInt32(ddl_DaysRented03.SelectedItem.Value);
            getCar(btn_int_ID, days_Rented);
        }



        void getCar(int btn_int_ID, int days_Rented)
        {
            for (int x = 0; x < cars.Count; x++)
            {
                if (btn_int_ID == x)
                {
                    tempCar = cars[x];
                    price = getPrice(cars[x].category);
                    subTotal = price * days_Rented;
                    rCar = new rentedCar(tempCar, price,subTotal, days_Rented);

                    if (Session["chosenCarsSession"] != null)
                    {
                        shoppingCart= (List<rentedCar>)Session["chosenCarsSession"];
                    }


                    shoppingCart.Add(rCar);
                    //sCart.Add(rCar);

                    Session["chosenCarsSession"] = shoppingCart;
                    break;
                }
            }
            SetCartDefaults();

        }

        decimal getPrice(string cat)
        {
            if (cat.Equals("Luxury"))
            {
                price = 10000;
            }
            else if (cat.Equals("Premium"))
            {
                price = 7500;
            }
            else if (cat.Equals("Standard"))
            {
                price = 5000;
            }
            return price;
        }

        void SetCartDefaults()
        {
            List<rentedCar> tempList = new List<rentedCar>();

            cartBtns.Add(btn_AddCart01);
            cartBtns.Add(btn_AddCart02);
            cartBtns.Add(btn_AddCart03);
           
            ddl_Days.Add(ddl_DaysRented01);
            ddl_Days.Add(ddl_DaysRented02);
            ddl_Days.Add(ddl_DaysRented03);

            cartLabels.Add(lbl_AddedCart01);
            cartLabels.Add(lbl_AddedCart02);
            cartLabels.Add(lbl_AddedCart03);

            if (Session["chosenCarsSession"] != null)
            {
                tempList = (List<rentedCar>)Session["chosenCarsSession"];

                for(int x=0;x<tempList.Count;x++)
                {
                    int temp_carIdx = tempList[x].cCar.car_int_ID;
                        cartBtns[temp_carIdx].Enabled = false;
                        ddl_Days[temp_carIdx].Enabled = false;
                        cartLabels[temp_carIdx].Visible = true;
                }
            }


        }

    }

    
}