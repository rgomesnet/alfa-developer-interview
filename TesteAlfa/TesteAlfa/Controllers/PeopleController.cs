using Microsoft.AspNetCore.Mvc;
using TesteAlfa.Models;

namespace TesteAlfa.Controllers
{
    public class PeopleController : Controller
    {
        private readonly PersonService service;

        public PeopleController()
        {
            this.service = new PersonService();

        }
        public IActionResult Index()
        {
            var people = this.service.List();
            return View(people);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            this.service.Create(person);
            return RedirectToAction("Index");
        }
    }
}
