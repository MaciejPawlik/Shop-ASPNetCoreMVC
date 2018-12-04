using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDBContext context)
        {
            if(!context.Cars.Any())
            {
                context.AddRange(
                    new Car
                    {
                        Brand = "BMW",
                        Model = "ZX",
                        Year = 2016,
                        Distance = "130km",
                        Volume = "2100cm3",
                        Fuel = "gasoline",
                        Description = "nice",
                        IsCarOfWeek = false,
                        Power = "310KM",
                        Price = 1245640
                    },
                    new Car
                    {
                        Brand = "Fiat",
                        Model = "500",
                        Year = 2014,
                        Distance = "1441km",
                        Volume = "1900cm3",
                        Fuel = "diesel",
                        Description = "good",
                        IsCarOfWeek = false,
                        Power = "234KM",
                        Price = 1246540
                    },
                    new Car
                    {
                        Brand = "Ford",
                        Model = "Escort",
                        Year = 2011,
                        Distance = "151km",
                        Volume = "2200cm3",
                        Fuel = "gasoline",
                        Description = "super",
                        IsCarOfWeek = false,
                        Power = "343KM",
                        Price = 1245640
                    },
                    new Car
                    {
                        Brand = "Merc",
                        Model = "SL",
                        Year = 2012,
                        Distance = "34324km",
                        Volume = "2300cm3",
                        Fuel = "diesel",
                        Description = "yeah",
                        IsCarOfWeek = false,
                        Power = "111KM",
                        Price = 12546460
                    },
                    new Car
                    {
                        Brand = "VW",
                        Model = "Golf",
                        Year = 2013,
                        Distance = "12343km",
                        Volume = "1200cm3",
                        Fuel = "gasoline",
                        Description = "uuuu",
                        IsCarOfWeek = true,
                        Power = "432KM",
                        Price = 1545450
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
