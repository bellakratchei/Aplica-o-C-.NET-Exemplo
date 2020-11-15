using BellaKratchei.PrimeiroTesteMVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BellaKratchei.PrimeiroTesteMVC.Web.Controllers
{
    public class TesteController : Controller
    {
        // O método é na verdade uma Action que pode ser chamada via URL
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {
            return View("Saudacao", pessoa);
        }
    }
}