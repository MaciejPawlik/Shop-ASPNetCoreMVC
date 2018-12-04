using Microsoft.AspNetCore.Mvc;
using Shop.Models;

namespace Shop.Controllers
{
    public class OpinionController : Controller
    {
        private readonly IOpinionRepository _opinionRepository;

        public OpinionController(IOpinionRepository opinionRepository)
        {
            _opinionRepository = opinionRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Opinion opinion)
        {
            if (ModelState.IsValid)
            {
                _opinionRepository.AddOpinion(opinion);
                return RedirectToAction("OpinionSent");
            }

            return View(opinion); // zwrot do ponownego wypełnienia z danymi
        }

        public IActionResult OpinionSent()
        {
            return View();
        }
    }
}