namespace GetTaxiSolution.Migrations
{
    using GetTaxiSolution.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Helpers;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<GetTaxiSolution.Models.TaxiAppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(GetTaxiSolution.Models.TaxiAppDbContext context)
        {
            context.Drivers.AddOrUpdate(t => t.UserName,
                      new Driver()
                      {
                          FirsName = "test",
                          LastName = "tesT",
                          Gender = Gender.MALE,
                          BirthDate = DateTime.Now.ToShortDateString(),
                          Experience = 5,
                          Phone = "0505556688",
                          EmailAddress = "test@test.com",
                          ImageUrl = "test",
                          UserName = "test",
                          Password = Helpers.GetPasswordHash("nese" + Helpers.PASSWORD_SALT)
                      });

            context.Bids.AddOrUpdate(bid => bid.BidID,
                    new Bid()
                    {
                        BidID = 111
                    },
                    new Bid()
                    {
                        BidID = 222
                    });

            context.Orders.AddOrUpdate(order => order.OrderID,
                    new Order()
                    {
                        OrderID = 1,
                        OrderDate = DateTime.Now,
                        SuggestedPrice = 10.3m,
                        LocationFrom = "28 Mall",
                        LocationTo = "Masazir",
                        Bids = null,
                        ChosenBid = null
                    },
                    new Order()
                    {
                        OrderID = 2,
                        OrderDate = DateTime.Now,
                        SuggestedPrice = 6.3m,
                        LocationFrom = "Khutor",
                        LocationTo = "Bulvar",
                        ChosenBid = new Bid()
                                    {
                                        BidID = 1
                                    }
                    });
        }
    }
}
