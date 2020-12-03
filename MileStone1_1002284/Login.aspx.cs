using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using MileStone1_1002284.Models;

namespace MileStone1_1002284
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (User.Identity.IsAuthenticated)
                {
                    StatusText.Text = string.Format("Hello {0}!!", User.Identity.GetUserName());
                    LoginStatus.Visible = true;
                    LogoutButton.Visible = true;
                }
                else
                {
                    //LoginForm.Visible = true;
                }
            }

        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            //GetUser();

           // var userStore = new UserStore<IdentityUser>();
            //var userManager = new UserManager<IdentityUser>(userStore);
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            var user = userManager.Find(txt_UserName.Text, txt_Password.Text);

            if (user != null)
            {
                var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = false }, userIdentity);
                Session.Clear();
                Response.Redirect("~/index.aspx");
            }
            else
            {
                StatusText.Text = "Invalid username or password.";
                LoginStatus.Visible = true;
            }

        }
        protected void SignOut(object sender, EventArgs e)
        { 
        }
            public void GetUser()
        {

            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
            authenticationManager.SignOut();
            Response.Redirect("~/Login.aspx");
            /*
            string userName=txt_UserName.Text.ToString();
            string pwd = txt_Password.Text.Replace(" ","").ToString();

            var _db = new MileStone1_1002284.Models.ApplicationDbContext();
            var mUser = _db.Users.Find(userName);
            if(mUser==null)
            {
                ClientScript.RegisterStartupScript(GetType(), "Message", "callAlert('User not found!')", true);

            }
            else
            {
                if(mUser.Paswword==pwd)
                {
                    ClientScript.RegisterStartupScript(GetType(), "Message", "callAlert('Correct Password!')", true);
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "Message", "callAlert('Incorrect Password!')", true);
                }

            }

            //var mUser = (from u in _db.Users where u.UserName == userName select u).First<User>();
            
            //IQueryable<User> query = _db.Users;





            
   <form id="form1" runat="server">
      <div>
         <h4 style="font-size: medium">Log In</h4>
         <hr />
         <asp:PlaceHolder runat="server" ID="LoginStatus" Visible="false">
            <p>
               <asp:Literal runat="server" ID="StatusText" />
            </p>
         </asp:PlaceHolder>
         <asp:PlaceHolder runat="server" ID="LoginForm" Visible="false">
            <div style="margin-bottom: 10px">
               <asp:Label runat="server" AssociatedControlID="UserName">User name</asp:Label>
               <div>
                  <asp:TextBox runat="server" ID="UserName" />
               </div>
            </div>
            <div style="margin-bottom: 10px">
               <asp:Label runat="server" AssociatedControlID="Password">Password</asp:Label>
               <div>
                  <asp:TextBox runat="server" ID="Password" TextMode="Password" />
               </div>
            </div>
            <div style="margin-bottom: 10px">
               <div>
                  <asp:Button runat="server" OnClick="SignIn" Text="Log in" />
               </div>
            </div>
         </asp:PlaceHolder>
         <asp:PlaceHolder runat="server" ID="LogoutButton" Visible="false">
            <div>
               <div>
                  <asp:Button runat="server" OnClick="SignOut" Text="Log out" />
               </div>
            </div>
         </asp:PlaceHolder>
      </div>
   </form>






           */

        }
    }
}