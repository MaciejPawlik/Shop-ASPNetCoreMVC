using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using Shop.ViewModels;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarRepository _carRepository;

        public HomeController(ICarRepository carRepository) // wstrzyknięcie zależności przez konstruktor
        {
            _carRepository = carRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var cars = _carRepository.GetAllCars().OrderBy(c => c.Brand);

            var homeVM = new HomeVM()
            {
                Title = "Przeglad samochodow",
                Cars = cars.ToList()
            };
            return View(homeVM);
        }

        public IActionResult Details(int id)
        {
            var car = _carRepository.GetCarById(id);
            if (car == null)
                return NotFound();

            return View(car);
        }
    }
}
