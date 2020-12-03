using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

using System.Security.Claims;
using System.Threading.Tasks;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace MileStone1_1002284.Models
{
    public class RentalContext:IdentityDbContext
    {
        public RentalContext():base("ChezRentals")
        {

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Price> Prices { get; set; }

       // public  DbSet<User> Users { get; set; }


    }

    
}