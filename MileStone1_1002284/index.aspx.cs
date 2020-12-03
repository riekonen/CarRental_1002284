using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MileStone1_1002284.Models;

namespace MileStone1_1002284
{
    
    public partial class WebForm1 : System.Web.UI.Page
    {
        List<Car> cars;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["HomePageCarsSession"] == null)
                {
                    IQueryable<Car> queryable = GetCars();
                    cars = new List<Car>(queryable);
                    CarsList.DataSource = queryable.ToList();
                    CarsList.DataBind();
                    Session["HomePageCarsSession"] = cars;
                }
                else
                {
                    cars = (List<Car>)Session["HomePageCarsSession"];
                    CarsList.DataSource = cars;
                    CarsList.DataBind();
                }
                    
                    

            }
        }

        public IQueryable<Car> GetCars()
        {
            var _db = new MileStone1_1002284.Models.ApplicationDbContext();
            IQueryable<Car> query = (_db.Cars.Include("Price")).Take(3);
            return query;
        }

    }
}