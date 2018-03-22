using HelloWorld.Models;
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

        public ActionResult Index3(string name)
        {

            if(string.IsNullOrEmpty(name))
                return View("Error");

            ViewData["Nom"] = name;
            return View("Index");
        }

        public ActionResult ListeClient()
        {
            Clients clients = new Clients();
            ViewData["ListeClient"] = clients.ObtenirListClient();
            return View("ListeClients");
        }

        public ActionResult ChercheClient(string name)
        {
            ViewData["Nom"] = name;

            Clients clients = new Clients();
            Client client = clients.ObtenirListClient().FirstOrDefault(c => c.Nom == name);

            if(client != null)
            {
                ViewData["Age"] = client.Age;
                return View("Trouve");
            }

            return View("NonTrouve");
        }
    }
}