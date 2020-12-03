using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using MileStone1_1002284.Classes;
using MileStone1_1002284.Models;

namespace MileStone1_1002284
{
    
    public partial class WebForm2 : System.Web.UI.Page
    {
        
        
        List<Button> cartBtns = new List<Button>();
        List<DropDownList> ddl_Days = new List<DropDownList>();
        List<Label> cartLabels = new List<Label>();
        List<Car> cars = new List<Car>();
        List<int> daysList = new List<int>();
        List<DateTime> daysList2 = new List<DateTime>();
        List<rentedCar> shoppingCart = new List<rentedCar>();
        rentedCar rCar;
        Car tempCar;
        int maxNumDays = 5;
        decimal price=0;
        decimal subTotal=0;
        string car_Category = "";
        public static bool authenticated;
        public string uName;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
               // Session["chosenCarsSession"] = shoppingCart;

             /*   Car honda = new Car("LXHC01","Honda Civic", "Luxury", "It nice!");
                Car toyota = new Car("PMTX01","Toyota Mark X", "Premium", "It nice bad!");
                Car toyota2 = new Car("SDTA01","Toyota Axio", "Standard", "It very nice!");

                cars.Add(honda);
                cars.Add(toyota);
                cars.Add(toyota2);*/
            if (!IsPostBack)
            {
                // GetCars();
                IQueryable<Car> queryable = GetCars();
                cars = new List<Car>(queryable);
                //cars = (queryable.Select(s => s)).ToList();                
                ProductsList.DataSource = queryable.ToList();
                ProductsList.DataBind();
                //IEnumerable<string> mUsers = (from u in _db.Users select u.UserName);
                Session["CarsSession"] = cars;
                
                if (User.Identity.IsAuthenticated)
                {
                    uName = User.Identity.GetUserName().ToString();
                    var _db = new MileStone1_1002284.Models.ApplicationDbContext();
                    //IQueryable<Cart> query = _db.Carts;
                    var mUser = (from u in _db.Carts where u.ApplicationUser.Id == uName select u).FirstOrDefault();
                    if (mUser == null)
                    {

                    }
                    else
                    {
                        // mUser = (from u in _db.Carts where u.CarID == uName select u);
                        //IQueryable<Cart> query = _db.Carts.Include("ApplicationUser");
                        IEnumerable<Cart> mUserCart = (from u in _db.Carts where u.ApplicationUser.Id == uName select u);
                        List<Cart>userCars = mUserCart.ToList();

                        /*if (Session["chosenCarsSession"] != null)
                        {
                            shoppingCart = (List<rentedCar>)Session["chosenCarsSession"];
                        }*/



                        foreach (var c in userCars)
                        {
                            rCar = new rentedCar(c.Car, c.Car.Price.UnitPrice, c.SubTotal);
                            shoppingCart.Add(rCar);

                        }
                        
                        //rCar = new rentedCar(tempCar, price, subTotal);
                        
                        Session["chosenCarsSession"] = shoppingCart;
                    }

                }


                SetCartDefaults();
            }

            


        }

        protected void btn_AddCart_Click(object sender, EventArgs e)
        {
            
            Button btn_AddCart = (Button)sender;
            string selected_CarId = btn_AddCart.CommandArgument.ToString();
           
           // ClientScript.RegisterStartupScript(GetType(), "Message", "callAlert(selected_CarId)", true);
            getCar(selected_CarId);           
        }
      


        void getCar(string carId)
        {
            cars= (List<Car>)Session["CarsSession"];

            
            for (int x = 0; x < cars.Count; x++)
            {
                if (cars[x].CarID==carId)
                {
                    tempCar = cars[x];
                    price = cars[x].Price.UnitPrice;
                    subTotal = price; //* days_Rented;
                    rCar = new rentedCar(tempCar, price,subTotal);

                    if (Session["chosenCarsSession"] != null)
                    {
                        shoppingCart= (List<rentedCar>)Session["chosenCarsSession"];
                    }


                    shoppingCart.Add(rCar);
                    Session["chosenCarsSession"] = shoppingCart;

                    if (User.Identity.IsAuthenticated)
                    {
                        uName = User.Identity.GetUserName().ToString();
                        var _db = new MileStone1_1002284.Models.ApplicationDbContext();
                        Cart cartObj = new Cart(uName,rCar.cCar.CarID, new DateTime(2021, 01, 03), new DateTime(2021, 01, 05), rCar.sTotal);
                        _db.Carts.Add(cartObj);
                        _db.SaveChanges();
                    }


                    //sCart.Add(rCar);

                    
                    break;
                }
            }
         //   ClientScript.RegisterStartupScript(GetType(), "Message", "callAlert('Added!')", true);
              SetCartDefaults();

        }


        void SetCartDefaults()
        {
            List<rentedCar> tempList = new List<rentedCar>();
                      
            if (Session["chosenCarsSession"] != null)
            {
                
                tempList = (List<rentedCar>)Session["chosenCarsSession"];
                
                for (int x=0;x<tempList.Count;x++)
                {
                    foreach (ListViewItem item1 in ProductsList.Items)
                    {
                        string selected_CarId="";
                        // txt_Date2.Text += item1.Controls.GetType().ToString();
                        Button button = (Button)item1.FindControl("btn_AddCart");
                        Label addedLabel = (Label)item1.FindControl("lbl_AddedCart");
                        selected_CarId = button.CommandArgument.ToString();
                        
                            
                       
                        if (selected_CarId==tempList[x].cCar.CarID)
                        {
                            //ImageButton imageBnutton = (ImageButton)item1;
                            
                            button.Enabled = false;
                            addedLabel.Visible = true;
                            //cB.Enabled = false;

                        }
                    }
                }
                       
                
            }

        }

        public IQueryable<Car> GetCars()
        {
            var _db = new MileStone1_1002284.Models.ApplicationDbContext();
            IQueryable<Car> query = _db.Cars.Include("Price");
            
            // var _db = new MileStone1_1002284.Models.RentalContext();
            // var mUsers = (from u in _db.Cars select u.Price.UnitPrice).ToList();
            // var mUser = _db.Cars.
            
            return query;

        }

         protected void calenderBtn_clicked(object sender, EventArgs e)
        {
            //var d=GetCars();
            //var c = (from u in d select u.CarID).ToList();
            Button iBtn = (Button)sender;
            string s = iBtn.CommandArgument.ToString();
            Calendar literal_Calender=new Calendar();
            
            //ClientScript.RegisterStartupScript(GetType(), "Message", "callAlert("+s+")", true);
            
            ListViewItem item = iBtn.NamingContainer as ListViewItem;
           
            literal_Calender = item.FindControl("calender1") as Calendar;

            // dateTextbox.Text = s.ToString();


            //  foreach (string u in c)
            //  {
            //     if (u==s)
            //     {
            // literal_Calender = (Calendar)item.FindControl("ProductsList_calendar_" + s);
            // literal_DateTextbox = (TextBox)item.FindControl("txt_Date_" + s);
            // }
            //}
            //  txt_Date2.Text = item.ID.ToString();

             if(literal_Calender.Equals(null))
             {
                 ClientScript.RegisterStartupScript(GetType(), "Message", "callAlert('User not found!')", true);

             }
             else
             {
                 literal_Calender.Visible = true;
             }


        }
        
        protected void Selection_changed(object sender, EventArgs e)
        {
            Calendar calendar = (Calendar)sender;
            ListViewItem item = calendar.NamingContainer as ListViewItem;
            Label dateLabel = new Label();
            dateLabel = item.FindControl("lbl_SelectStartDate") as Label;

            DateTime startDate = new DateTime();
            //DateTime endDate = new DateTime();
            startDate = calendar.SelectedDate.Date;
            //dateLabel.Text = startDate.ToShortDateString();
            // if (Session["chosenDatesSession"] != null)
            // {
            //   daysList2 = (List<DateTime>)Session["chosenDatesSession"];
            dateLabel.Text = calendar.SelectedDate.ToShortDateString() ;

           // }

                
            calendar.Visible = false;
            
        }


        protected void Selection2_changed(object sender, EventArgs e)
        {
            Calendar calendar = (Calendar)sender;
            ListViewItem item = calendar.NamingContainer as ListViewItem;
            Label dateLabel = new Label();
            dateLabel = item.FindControl("lbl_SelectEndDate") as Label;

            //DateTime startDate = new DateTime();
            //DateTime endDate = new DateTime();
            //startDate = calendar.SelectedDate;
            //dateLabel.Text = startDate.ToShortDateString();
            if (Session["chosenDatesSession"] != null)
            {
                daysList2 = (List<DateTime>)Session["chosenDatesSession"];
                dateLabel.Text = calendar.SelectedDate.ToString();

            }


            calendar.Visible = false;

        }







        protected void Calender1_DayRender(object sender,DayRenderEventArgs e)
        {
            List<DateTime> tempList = new List<DateTime>();
            if (e.Day.IsSelected == true)
                {
                    tempList.Add(e.Day.Date);
                }
                Session["chosenDatesSession"] = tempList;
               //DateTime endDate = calendar.SelectedDate;          
                      
        }

        protected void Calender2_DayRender(object sender, DayRenderEventArgs e)
        {
            List<DateTime> tempList = new List<DateTime>();
            Calendar calendar = (Calendar)sender;
            //ListViewItem item = calendar.NamingContainer as ListViewItem;
            //Label dateLabel = new Label();
            //dateLabel = item.FindControl("lbl_SelectStartDate") as Label;

            if (Session["chosenDatesSession"] != null)
            {
               tempList = (List<DateTime>)Session["chosenDatesSession"];
                if(e.Day.Date<=tempList[0])
                {
                    e.Day.IsSelectable = false;
                }

            }

        }







        [WebMethod(EnableSession =true)]
        public static void SaveData()
        {
            
            /*
           
            if (authenticated && HttpContext.Current.Session["chosenCarsSession"] != null)
            {
                //  ClientScript.RegisterStartupScript(GetType(), "Message", "callAlert('Select an item to remove!')", true);

                List<rentedCar> cartList=new List<rentedCar>();
                cartList = (List<rentedCar>)HttpContext.Current.Session["chosenCarsSession"];
                var _db = new MileStone1_1002284.Models.ApplicationDbContext();
                //IQueryable<Cart> query = _db.Carts;
                foreach(var c in cartList)
                {
                    Cart cartObj = new Cart(uName,c.cCar.CarID, new DateTime(2021, 01, 03), new DateTime(2021, 01, 05),20);
                    _db.Carts.Add(cartObj);
                }

                _db.SaveChanges();
            }*/
        }


    }

   

    
}