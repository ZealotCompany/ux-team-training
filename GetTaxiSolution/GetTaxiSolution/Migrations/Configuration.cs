namespace GetTaxiSolution.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Helpers;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<GetTaxiSolution.Models.TaxiAppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GetTaxiSolution.Models.TaxiAppDbContext context)
        {
            context.TaxiDrivers.AddOrUpdate(t => t.UserName,
                      new TaxiDriver()
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
        }
    }
}
