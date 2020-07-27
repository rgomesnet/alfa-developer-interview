using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteAlfa.Models;

namespace TesteAlfa.Controllers
{
    public class AirportsController : Controller
    {
        private readonly AirportService service;

        public AirportsController()
        {
            this.service = new AirportService();
        }

        public ActionResult Index()
        {
            var airports = this.service.List();
            return View(airports);
        }
    }
}
