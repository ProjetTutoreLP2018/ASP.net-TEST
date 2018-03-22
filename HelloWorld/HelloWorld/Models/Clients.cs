using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.Models
{
    public class Clients
    {

        public List<Client> ObtenirListClient()
        {
            return new List<Client>
            {
                new Client { Nom = "Joe", Age = 19 },
                new Client("Driss", 19),
                new Client("Charlotte", 19),
                new Client("Kevin", 29)
            };
        }
    }
}