using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Singleton_Transient_Scoped_Demo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Singleton_Transient_Scoped_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISingletonService _singleton1;
        private readonly ISingletonService _singleton2;
        private readonly ItransientService _transient1;
        private readonly ItransientService _transient2;
        private readonly IScopedService _scoped1;
        private readonly IScopedService _scoped2;
        public HomeController(ILogger<HomeController> logger,ISingletonService singleton1,ItransientService transient1,
            IScopedService scoped1,ISingletonService singleton2,ItransientService transient2,IScopedService scoped2)
        {
            _logger = logger;
            _singleton1 = singleton1;
            _singleton2 = singleton2;
            _transient1 = transient1;
            _transient2 = transient2;
            _scoped1 = scoped1;
            _scoped2 = scoped2;
        }

        public IActionResult Index()
        {
            ViewBag.st1 = _singleton1.GetOperationID();
            ViewBag.st2 = _singleton2.GetOperationID();
            ViewBag.t1 = _transient1.GetOperationID();
            ViewBag.t2 = _transient2.GetOperationID();
            ViewBag.sc1 = _scoped1.GetOperationID();
            ViewBag.sc2 = _scoped2.GetOperationID();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
