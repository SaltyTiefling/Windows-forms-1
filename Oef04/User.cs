using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef04
{
    class User
    {
        public string voornaam { get; set; }
        public string achternaam { get; set; }

        public User(string voornaam, string achternaam)
        {
            this.voornaam = voornaam;
            this.achternaam = achternaam;
        }



    }
}
