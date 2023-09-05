using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeughandel
{
    internal class Probefahrt
    {
        public int Nummer;
        public DateTime Datum;
        public Fahrzeug Auto;

        public Probefahrt(int nummer, DateTime datum, Fahrzeug auto, int menge)
        {
            Nummer = nummer;
            Datum = datum;
            Auto = auto;
        }

        public static void Verkaufen(Probefahrt probefahrt, int index)
        {        
                if (Entscheidung() || VerkaufAutos[index] == probefahrt)
                {
                    Probefahrt.VerkaufAutos[index] = probefahrt;
                    Console.WriteLine($"Die Autobestellungnr: {probefahrt.Nummer}, mit Probefahrt vom {probefahrt.Datum}, wurde verkauft");
                }
                else
                {
                    Probefahrt.VerkaufAutos[index] = null;
                    Console.WriteLine($"Die Autobestellungnr: {probefahrt.Nummer}, mit Probefahrt vom {probefahrt.Datum}, wurde NICHT verkauft");
                }
        }
        public static void ProbefahrtTermine(Probefahrt probefahrt)
        {
            Console.WriteLine($"\n\tVom {probefahrt.Datum}: {probefahrt.Auto.Hersteller}, {probefahrt.Auto.Modell}, {probefahrt.Auto.Farbe}, {probefahrt.Auto.PS} PS");
        }

        public static bool Entscheidung()
        {

            int zz = Random.Shared.Next(0, 2);

            if (zz < 1)
            {
                return false;
            }
            return true;
        }

        public static Probefahrt[] VerkaufAutos = new Probefahrt[6];
    }
}
