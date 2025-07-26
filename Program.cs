using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fahrzeughandel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Erstellen Sie eine Consolen-Anwendung für einen Fahrzeughandel.
            //
            //Die App soll in der Lage sein (mit Testdaten im Code) Fahrzeuge die verfügbar sind zu verwalten.
            //Diese Fahrzeuge können von Kunden für eine Probefahrt zu einem bestimten Termin reserviert werden.
            //Diese Probefahrten können zu einem Verkauf führen der dann auch in der App Verwaltet werden soll,
            //dabei verschwindet das Fahrzeug natürlich von der Sammlung der Verfügbaren Fahrzeuge.

            Fahrzeug seat1 = new Fahrzeug("Seat", "Altea", "Schwarz", 106);
            Fahrzeug seat2 = new Fahrzeug("Seat", "Leon", "Weiß", 120);
            Fahrzeug volkswagen1 = new Fahrzeug("Volkswagen", "Polo", "Blau", 90);
            Fahrzeug volkswagen2 = new Fahrzeug("Volkswagen", "Golf", "Grün", 140);
            Fahrzeug audi1 = new Fahrzeug("Audi", "A6", "Rot", 160);
            Fahrzeug audi2 = new Fahrzeug("Audi", "A5", "Grau", 130);

            Probefahrt testProbefahrt1 = new Probefahrt(10, new DateTime(2023, 04, 25, 08, 20, 00), audi1, 0);
            Probefahrt testProbefahrt2 = new Probefahrt(26, new DateTime(2023, 05, 02, 10, 50, 00), volkswagen1, 0);
            Probefahrt testProbefahrt3 = new Probefahrt(31, new DateTime(2023, 05, 03, 11, 40, 00), seat2, 0);
            Probefahrt testProbefahrt4 = new Probefahrt(40, new DateTime(2023, 05, 20, 14, 30, 00), seat1, 0);
            Probefahrt testProbefahrt5 = new Probefahrt(39, new DateTime(2023, 05, 11, 19, 40, 00), volkswagen2, 0);
            Probefahrt testProbefahrt6 = new Probefahrt(51, new DateTime(2023, 05, 22, 21, 50, 00), audi2, 0);

            Fahrzeug[] autosArray = new Fahrzeug[] { seat1, seat2, volkswagen1, volkswagen2, audi1, audi2 };

            Probefahrt[] testProbefahrtArray = new Probefahrt[] { testProbefahrt1, testProbefahrt2, testProbefahrt3, testProbefahrt4, testProbefahrt5, testProbefahrt6 };

            Console.WriteLine("Probefahrt Termine im System:");
            foreach (Probefahrt probefahrt in testProbefahrtArray)
            {
                Probefahrt.ProbefahrtTermine(probefahrt);
            }

            VerkauftAutosAnzeigen();

            for (int i = 0; i < testProbefahrtArray.Length; i++)
            {
                Probefahrt probefahrt = testProbefahrtArray[i];
                Probefahrt.Verkaufen(probefahrt, i);
            }

            VerkauftAutosAnzeigen();

            void VerkauftAutosAnzeigen()
            {
                Console.WriteLine("\nAktuelle Liste mit Autos zum verkaufen:");
                for (int i = 0; i < Probefahrt.VerkaufAutos.Length; i++)
                {
                    if (Probefahrt.VerkaufAutos[i] != null)
                    {
                        Console.WriteLine($"\t{autosArray[i].Hersteller} {autosArray[i].Modell} {autosArray[i].Farbe} {autosArray[i].PS} PS (NICHT MEHR VERFÜGBAR)");
                    }
                    else
                    {
                        Console.WriteLine($"\t{autosArray[i].Hersteller} {autosArray[i].Modell} {autosArray[i].Farbe} {autosArray[i].PS} PS");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}