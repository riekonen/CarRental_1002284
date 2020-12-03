using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using Microsoft.AspNetCore.Identity;
using MileStone1_1002284.Logic;

using Microsoft.AspNet.Identity.EntityFramework;

namespace MileStone1_1002284.Models
{
    public class RentalDatabaseInitializer:DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        IdentityResult IdUserResult;
        protected override void Seed(ApplicationDbContext context)
        {
            base.Seed(context);
            RoleActions roleActions = new RoleActions();
            roleActions.AddUserAndRole();

            /* foreach (var u in GetUsers())
             {
                 u.PasswordHash = (new PasswordHasher<ApplicationUser>()).HashPassword(u, "password");
                 context.Users.Add(u);

             }*/
            //GetUsers().ForEach(u => context.Users.Add(u));
            GetPrices().ForEach(p => context.Prices.Add(p));
            GetCars().ForEach(c => context.Cars.Add(c));

            foreach (var u in GetCarts())
            {
                //u.Id = u.ApplicationUser.Id;
            }

                GetCarts().ForEach(ca => context.Carts.Add(ca));

           
        }

        private static List<ApplicationUser> GetUsers()
        {
            var Users = new List<ApplicationUser>
            {
                new ApplicationUser
                {
                    UserName="chez",
                    Id="chez10",
                //    PasswordHash=(new PasswordHasher<ApplicationUser>()).HashPassword(new ApplicationUser,"password")
                },
               
               

            };
            return Users;
        }

        private static List<Car> GetCars()
        {
            var Cars = new List<Car>
            {
                new Car
                {
                    CarID = "LXHC01",
                    CarName = "Honda Civic",
                    Category = "Luxury",
                    Description = "The 2019 Honda Civic is a luxurious machine offering style, comfort and grace. It boasts a clean, spacious interior, comfortably seating 3 passengers. It comes with a Radio/CD/Bluetooth player, MP3 interface, GPS Navagiation, fully A/C, automatic transmission among other awesome specs.",
                    imageUrl="hondacivic.png",                  
                    
                },
                new Car
                {
                    CarID = "PMTX01",
                    CarName = "Toyota Mark X",
                    Category = "Premium",
                    Description = "Stepping in the Toyota Mark X feels like a world of premium. Premium interior, premium ride comfort, premium experience. It comfortably seats 3 passengers and comes with a Radio/CD/Bluetooth player, MP3 interface, GPS Navagiation, fully A/C, automatic transmission among other awesome specs.Contact Us for more Details.",
                    imageUrl="markx.png",
                },
                new Car
                {
                    CarID = "SDTA01",
                    CarName = "Toyota Axio",
                    Category = "Standard",
                    Description = "There is nothing like crusing in comfort, which is an experience you can live in the Toyota Axio. This 4 door sedan offers a clean cut, smooth sailing ride experience at a ridulously awesome rate. It comes standard with spacious interior, comfortably seating 3 passengers, a Radio/CD/Bluetooth player, MP3 interface, GPS Navagiation, fully A/C, automatic transmission among other awesome specs.Contact Us for more Details.",
                    imageUrl="axio.png",

                },
                new Car
                {
                    CarID = "SDHF01",
                    CarName = "Honda Fit",
                    Category = "Premium",
                    Description = "There is nothing like driving in comfort, which is an experience you can live in the Honda Fit.",
                    imageUrl="hondafit.png",

                },
                new Car
                {
                    CarID = "LXMB01",
                    CarName = "Mercedes Benz",
                    Category = "Luxury",
                    Description = "It nice!",
                    imageUrl="benz.png",

                }

            };
            return Cars;
        }

        private static List<Price> GetPrices()
        {
            var Prices = new List<Price>
            {
                new Price
                {
                   Category = "Premium",
                   UnitPrice = 7500,
                },
                new Price
                {
                   Category = "Luxury",
                   UnitPrice = 10000,
                },
                new Price
                {
                   Category = "Standard",
                   UnitPrice = 5000,
                },

            };
            return Prices;
        }

        private static List<Cart> GetCarts()
        {
            var Carts = new List<Cart>
            {
                new Cart
                {
                   CarID="PMTX01",
                   Id="chez@gmail.com",                                
                   StartDate=new DateTime(2021,01,03), 
                   EndDate=new DateTime(2021,01,04),
                   SubTotal=7500, 
                  
                },

            };
            return Carts;
        }

    }


}