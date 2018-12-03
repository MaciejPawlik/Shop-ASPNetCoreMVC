using System.Collections.Generic;
using System.Linq;

namespace Shop.Models
{
    public class MockCarsRepository : ICarRepository
    {

        private List<Car> carList;

        public MockCarsRepository()
        {
            if (carList == null)
            {
                LoadCars();
            }
        }

        private void LoadCars()
        {
            carList = new List<Car>();
            carList.Add(new Car { Id = 1, Brand = "BMW", Model = "ZX", Year = 2016, Distance = "130km", Volume = "2100cm3",
                    Fuel = "gasoline", Description = "nice", IsCarOfWeek = false, Power="310KM", Price= 1245640 });
            carList.Add(new Car { Id = 2, Brand = "Fiat", Model = "500", Year = 2014, Distance = "1441km", Volume = "1900cm3",
                    Fuel = "diesel", Description = "good", IsCarOfWeek = false, Power="234KM", Price= 1246540 });
            carList.Add(new Car { Id = 3, Brand = "Ford", Model = "Escort", Year = 2011, Distance = "151km", Volume = "2200cm3",
                    Fuel = "gasoline", Description = "super", IsCarOfWeek = false, Power="343KM", Price= 1245640 });
            carList.Add(new Car { Id = 4, Brand = "Merc", Model = "SL", Year = 2012, Distance = "34324km", Volume = "2300cm3",
                    Fuel = "diesel", Description = "yeah", IsCarOfWeek = false, Power="111KM", Price= 12546460 });
            carList.Add(new Car { Id = 5, Brand = "VW", Model = "Golf", Year = 2013, Distance = "12343km", Volume = "1200cm3",
                    Fuel = "gasoline", Description = "uuuu", IsCarOfWeek = true, Power="432KM", Price= 1545450 });  
        }

        public IEnumerable<Car> GetAllCars()
        {
            return carList;
        }



        public Car GetCarById(int id)
        {
            return carList.FirstOrDefault(c => c.Id == id);
        }
    }
}
