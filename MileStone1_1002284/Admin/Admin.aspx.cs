using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MileStone1_1002284.Models;

namespace MileStone1_1002284
{
    public partial class Admin : System.Web.UI.Page
    {
        List<string> CategoryList = new List<string>();
        List<string> CarNameList = new List<string>();
        List<Car> carsList;
        IEnumerable<string> mCategory=null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // if (Session["HomePageCarsSession"] == null)
                //  {
                IQueryable<Car> queryable = GetCars();
                carsList = new List<Car>(queryable);

                if (mCategory != null)
                {
                    CategoryList = mCategory.ToList();
                    ddl_Category.DataSource = CategoryList;
                    ddl_Category.DataBind();
                }
                CarNameList= (from n in carsList select n.CarName).ToList();
                ddl_Cars.DataSource = CarNameList;
                
                ddl_Cars.DataBind();
                


                Session["CarsSession"] = carsList;
                //  }

            }
        }

        public IQueryable<Car> GetCars()
        {
            var _db = new MileStone1_1002284.Models.ApplicationDbContext();
            IQueryable<Car> query = _db.Cars.Include("Price");
            mCategory = (from c in _db.Prices select c.Category);
            return query;
        }

        protected void btn_LoadCar_Click(object sender, EventArgs e)
        {

        }

        protected void btn_SelectImage_Click(object sender, EventArgs e)
        {
            string folderPath = Server.MapPath("~/images/");
            if(!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            fileUpload.SaveAs(folderPath + Path.GetFileName(fileUpload.FileName));
            txt_ImageUrl.Text = fileUpload.FileName.ToString();

        }

        protected void btn_AddCar_Click(object sender, EventArgs e)
        {
            var _db = new MileStone1_1002284.Models.ApplicationDbContext();
            string cName = txt_CarName.Text.ToString();
            string cID = txt_CarID.Text.ToString();
            string cCat = ddl_Category.SelectedValue.ToString();
            string cDes = txt_Description.Text.ToString();
            string cImgUrl = txt_ImageUrl.Text.ToString();

            Car newCar = new Car(cID, cName, cCat, cDes,cImgUrl);
            
            _db.Cars.Add(newCar);
            _db.SaveChanges();
            ClientScript.RegisterStartupScript(GetType(), "Message", "callAlert('Car Added to Database!')", true);


        }

        protected void btn_DeleteCar_Click(object sender, EventArgs e)
        {
            if (Session["CarsSession"] != null)
            {
                carsList = (List<Car>)Session["CarsSession"];
            }
            var _db = new MileStone1_1002284.Models.ApplicationDbContext();
            string selectedCar = ddl_Cars.SelectedValue.ToString();
            int selectedIndx = ddl_Cars.SelectedIndex;

            if(carsList[selectedIndx].CarName==selectedCar)
            {
                // _db.Cars.Attach(carsList[selectedIndx]);
                // _db.Cars.Remove(carsList[selectedIndx]);
                Car car = (from c in _db.Cars where c.CarName == selectedCar select c).First<Car>();
                if (car != null)
                {
                    _db.Cars.Remove(car);
                    _db.SaveChanges();
                    ClientScript.RegisterStartupScript(GetType(), "Message", "callAlert('Deleted!')", true);

                }

            }
            else
            {
                
            }


        }
    }
}