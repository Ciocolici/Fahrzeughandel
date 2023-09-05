using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeughandel
{
    internal class Fahrzeug
    {
        public string Hersteller;
        public string Modell;
        public string Farbe;
        public int PS;

        public Fahrzeug(string hersteller, string modell, string farbe, int pS)
        {
            Hersteller = hersteller;
            Modell = modell;
            Farbe = farbe;
            PS = pS;
        }
    }
}
