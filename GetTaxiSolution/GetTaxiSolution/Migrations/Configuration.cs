namespace GetTaxiSolution.Migrations
{
    using GetTaxiSolution.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GetTaxiSolution.Models.TaxiAppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GetTaxiSolution.Models.TaxiAppDbContext context)
        {
            List<Car> cars = new List<Car>()
          {
              new Car(){ Brand=CarBrand.BMW, ImageUrl="test", Model="M5", Type=CarType.SEDAN, Year=new DateTime(2000,01,01)},
              new Car(){ Brand=CarBrand.MERCEDES, ImageUrl="test", Model="C500", Type=CarType.SEDAN, Year=new DateTime(2000,01,01)}           
          };
            cars.ForEach(c => context.Cars.Add(c));
            context.SaveChanges();

            List<Driver> drivers = new List<Driver>()
         {
             new Driver(){BirthDate=new DateTime(2000, 01, 01), CarID=cars[0].CarID, EmailAddress="test@test.com", Experience=1, FirstName="Rufet", LastName="Isayev", Gender=Gender.MALE, ImageUrl="test", Phone="123456", UserName="rufi", Password=Helpers.Helpers.GetPasswordHash("rufi")},
             new Driver(){BirthDate=new DateTime(2000, 01, 01), CarID=cars[1].CarID, EmailAddress="test@test.com", Experience=1, FirstName="Azer", LastName="Seferov", Gender=Gender.MALE, ImageUrl="test", Phone="123456", UserName="azik", Password=Helpers.Helpers.GetPasswordHash("azik")}
         };
            drivers.ForEach(d => context.Drivers.Add(d));
            context.SaveChanges();

            Order order = new Order()
            {
                Bids = null,
                ChosenBid = null,
                OrderDate = DateTime.Now,
                SuggestedPrice = 15.00m,
                LocationFrom = "28 may",
                LocationTo = "Masazir"
            };
            context.Orders.Add(order);
            context.SaveChanges();

            List<Bid> bids = new List<Bid>()
            {
                new Bid(){DriverID=drivers[0].DriverID, OrderID=order.OrderID, Price=12.00m},
                new Bid(){DriverID=drivers[1].DriverID, OrderID=order.OrderID, Price=22.00m}         
            };           
           
            bids.ForEach(b => context.Bids.Add(b));
            context.SaveChanges();

            List<Comment> comments = new List<Comment>()
            {
                new Comment(){BidID=bids[0].BidID, Text="test"},
                new Comment(){BidID=bids[1].BidID, Text="test"},
                new Comment(){BidID=bids[0].BidID, Text="test"},
                new Comment(){BidID=bids[0].BidID, Text="test"},
                new Comment(){BidID=bids[1].BidID, Text="test"}
            };
            comments.ForEach(c => context.Comments.Add(c));
            context.SaveChanges();
        }
    }
}
      
