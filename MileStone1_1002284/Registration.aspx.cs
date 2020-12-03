using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MileStone1_1002284.Models;


using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MileStone1_1002284
{
    public partial class Registration : System.Web.UI.Page
    {
        List<string> userNames = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
              /*  var _db = new MileStone1_1002284.Models.RentalContext();
                //var mUsers = (from u in _db.Users select u.UserName).ToList();
                IEnumerable<string> mUsers = (from u in _db.Users select u.UserName);
                userNames = mUsers.ToList();
                
                if (userNames.Any())
                {
                    txt_userName.Text = userNames.First().ToString(); //mUsers.First().ToString();
                    txt_Password.Text = userNames.Count.ToString();
                }
                else
                {
                    txt_userName.Text = "null";
                }

                Session["userNamesSession"] = userNames;*/

            }
        }

        protected void btn_Register_Click(object sender, EventArgs e)
        {
            /*
            RentalContext context = new MileStone1_1002284.Models.RentalContext();

            var userMgr = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            var user = new ApplicationUser() { UserName = txt_userName.Text };
            IdentityResult result = userMgr.Create(user, txt_Password.Text);

            if (result.Succeeded)
            {
                Analytics.Client.Identify(user.Id, new Segment.Model.Traits
            {
                { "name", user.UserName },
                { "email", user.Email }
            });

                Analytics.Client.Track(user.Id, "Signup");

                IdentityHelper.SignIn(manager, user, isPersistent: false);
                IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            }
            else
            {
                ErrorMessage.Text = result.Errors.FirstOrDefault();
            }
        }


            */


















        /*
        if (Session["userNamesSession"] != null)
        {
            userNames = (List<string>)Session["userNamesSession"];

            string userName = txt_userName.Text.Replace(" ","").ToString();
            string pwd = txt_Password.Text.ToString();
            string confrimPwd = txt_confirmPassword.Text.ToString();
            //string result = userNames.FirstOrDefault(s => s == userName).ToString();
            bool found = (userNames.Any(s => userName.Contains(s)));

        if(found==true)
        {
            ClientScript.RegisterStartupScript(GetType(), "Message", "callAlert('User Name already taken!')", true);
        }
        else
        {
            ClientScript.RegisterStartupScript(GetType(), "Message", "callAlert('User Name is good!')", true);


                if (pwd == confrimPwd)
                {
                    ClientScript.RegisterStartupScript(GetType(), "Message", "callAlert('good!')", true);

                    User newUser = new User(userName, pwd, "User");
                    var _db = new MileStone1_1002284.Models.RentalContext();
                    _db.Users.Add(newUser);
                    _db.SaveChanges();
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "Message", "callAlert('bad!')", true);
                }

            }
        }
        else { ClientScript.RegisterStartupScript(GetType(), "Message", "callAlert('session empty!')", true); }

        */
    }

        public void comparePwd()
        {
            
        }
    }

   
}