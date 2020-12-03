using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MileStone1_1002284.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MileStone1_1002284.Logic
{
    internal class RoleActions
    {
        internal void AddUserAndRole()
        {
            //throw new NotImplementedException();
             Models.ApplicationDbContext context = new ApplicationDbContext();
           /// Models.RentalContext context = new RentalContext();
            IdentityResult IdRoleResult;
            IdentityResult IdUserResult;

           // var roleStore = new RoleStore<IdentityRole>(context);
            var roleMgr = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));
           // var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));

            if (!roleMgr.RoleExists("canEdit"))
            {
                IdRoleResult = roleMgr.Create(new IdentityRole { Name = "canEdit" });

            }

            var userMgr = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            var appUser = new ApplicationUser
            {
                UserName = "admin@chezrentals.com",
                Email = "admin@chezrentals.com",
                Id = "admin@chezrentals.com"
            };

            var appUser2 = new ApplicationUser
            {
                UserName = "chez@gmail.com",
                Email = "chez@gmail.com",
                Id = "chez@gmail.com",
            };

            IdUserResult = userMgr.Create(appUser2, "pwd123");
            IdUserResult = userMgr.Create(appUser, "pwdADMIN");

            if (!userMgr.IsInRole(userMgr.FindByEmail("admin@chezrentals.com").Id, "canEdit"))
            {
                IdUserResult = userMgr.AddToRole(userMgr.FindByEmail("admin@chezrentals.com").Id, "canEdit");
            }



        }
    }
}