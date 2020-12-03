﻿using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity.EntityFramework;
using Owin;
using MileStone1_1002284.Models;

namespace MileStone1_1002284.Account
{
    public partial class Register : Page
    {
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            // var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            //var signInManager = Context.GetOwinContext().Get<ApplicationSignInManager>();
           // var userStore = new UserStore<ApplicationUser>(new ApplicationDbContext);
           // var manager = new UserManager<ApplicationUser>(userStore);
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            var user = new ApplicationUser() { UserName = Email.Text, Email = Email.Text };
            IdentityResult result = manager.Create(user, Password.Text);
            if (result.Succeeded)
            {

                var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                var userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                authenticationManager.SignIn(new Microsoft.Owin.Security.AuthenticationProperties(){ },userIdentity);
                Response.Redirect("~/index.aspx");

                // For more information on how to enable account confirmation and password reset please visit https://go.microsoft.com/fwlink/?LinkID=320771
                //string code = manager.GenerateEmailConfirmationToken(user.Id);
                //string callbackUrl = IdentityHelper.GetUserConfirmationRedirectUrl(code, user.Id, Request);
                //manager.SendEmail(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>.");

                //   signInManager.SignIn( user, isPersistent: false, rememberBrowser: false);
                // IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
                ClientScript.RegisterStartupScript(GetType(), "Message", "callAlert('correct!')", true);

            }
            else 
            {
                ClientScript.RegisterStartupScript(GetType(), "Message", "callAlert('Incorrect!')", true);

                // ErrorMessage.Text = result.Errors.FirstOrDefault();
            }
        }
    }
}