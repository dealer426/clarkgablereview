using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cgr.Models;
using Microsoft.AspNetCore.Mvc;

namespace cgr.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var model = new ProductRepositroy();
            model.AddToDictionary();
            model.ReturnDictionary();

            return View(model);
        }
    }
}