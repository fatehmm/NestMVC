using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NestProject.Controllers
{
    public class ShopController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Product()
        {
            return View();
        }

        public IActionResult Compare()
        {
            return View();
        }

    }
}

