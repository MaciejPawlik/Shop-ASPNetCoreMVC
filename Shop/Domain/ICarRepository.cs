using System.Collections.Generic;

namespace Shop.Models
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();
        Car GetCarById(int id);
    }
}
