using System.Collections.Generic;
using System.Linq;

namespace Shop.Models
{
    public class CarRepository : ICarRepository
    {
        private readonly AppDBContext _appDBContext;

        public CarRepository(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext; // lokalna instancja równa się wstrzykniętej
        }
        public IEnumerable<Car> GetAllCars()
        {
            return _appDBContext.Cars;
        }

        public Car GetCarById(int id)
        {
            return _appDBContext.Cars.FirstOrDefault(c => c.Id == id);
        }
    }
}
