using Microsoft.AspNetCore.Mvc;
using Razor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Razor.Controllers
{
    public class HomeController: Controller
    {
        public ViewResult Index()
        {
            Product[] array =
            {
                  new Product{Name="Lodka", Price=300 }
                , new Product{Name="Kater", Price=500 }
                , new Product{Name="Iahta", Price=1000000 }
            };

            return View(array);
        }
    }
}

