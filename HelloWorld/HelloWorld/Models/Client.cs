using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.Models
{
    public class Client
    {

        public string Nom { get; set; }
        public int Age { get; set; }

        public Client(string nom, int age)
        {
            this.Nom = nom;
            this.Age = age;
        }

        public Client() : this("Unknow", 0) { }


    }
}