using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Je suis l'Index";
        }

        public string Index2(int? value)
        {
            return "Je suis l'Index2 et mon paramètre est : " + value;
        }
    }
}