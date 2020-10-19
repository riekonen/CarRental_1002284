using MileStone1_1002284.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MileStone1_1002284
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        List <rentedCar> rList=new List<rentedCar>();
        decimal grandTotal = 0;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                popGridVew();
            }

           
            //  TextBox1.Text = rList[0].rDays.ToString();

        }
        
        void Cal_GrandTotal()
        {
            if(rList.Count==0)
            {
                grandTotal = 0;
            }
            else
            {
                for (int x = 0; x < rList.Count; x++)
                {
                    grandTotal += rList[x].sTotal;
                }
            }
            tb_GrandTotal.Text = grandTotal.ToString();
        }

        void RemoveItem(string carId)
        {
            if (Session["chosenCarsSession"] != null)
            {
                rList = (List<rentedCar>)Session["chosenCarsSession"];
            }

                for (int x = 0; x < rList.Count; x++)
            {
                if (rList[x].cCar.car_ID.Equals(carId))
                {
                    rList.RemoveAt(x);
                    Session["chosenCarsSession"] = rList;
                }
            }

            popGridVew();
        }

        protected void btn_RemoveItem_Click(object sender, EventArgs e)
        {
            bool nothingChecked = true;
            if (Session["chosenCarsSession"]== null)
            {
                ClientScript.RegisterStartupScript(GetType(), "Message", "callAlert('Your Cart is Empty! Check out our Products page!')", true);
            }
            else
            {
                
                foreach (GridViewRow carRec in GridView1.Rows)
                {

                    CheckBox del_CheckBox = (CheckBox)carRec.FindControl("delChkBx");

                    // del_CheckBox.Checked = true;

                    if (del_CheckBox.Checked == true)
                    {
                        nothingChecked = false;
                        string carID = Convert.ToString(carRec.Cells[0].Text);
                        RemoveItem(carID);
                    }
                }
                if(nothingChecked==true)
                {
                    ClientScript.RegisterStartupScript(GetType(), "Message", "callAlert('Select an item to remove!')", true);
                }
            }

                       
        }

        void popGridVew()
        {
            if (Session["chosenCarsSession"] != null)
            {
                rList = (List<rentedCar>)Session["chosenCarsSession"];
            }
                GridView1.DataSource = rList;
                GridView1.DataBind();
                Cal_GrandTotal();
            
            
        }
    }
}