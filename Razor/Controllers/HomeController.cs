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
            Product myProduct = new Product
            {
                 ProductId      = 1
                , Name          = "Lodka"
                , Description   = "A boat for one person"
                , Price         = 275M
            };

            ViewBag.StockLavel = 2;

            return View(myProduct);
        }
    }
}
