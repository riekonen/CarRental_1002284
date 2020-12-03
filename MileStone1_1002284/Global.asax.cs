using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Data.Entity;
using MileStone1_1002284.Models;
using MileStone1_1002284.Logic;

namespace MileStone1_1002284
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Database.SetInitializer(new RentalDatabaseInitializer());



            // RentalContext context = new RentalContext();
            ApplicationDbContext context = new ApplicationDbContext();

         /*   if (context.Database.Exists()) { 
                context.Database.Delete(); 
        }*/

            if (!context.Database.Exists())
           {
                context.Database.Initialize(true);
                context.Database.CreateIfNotExists();

                
            }
            




        }
    }
}