using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ZvireciMetody
    {

        public static void Zvire() 
        {
            Zvire zvire1 = new Zvire(Druh.KOCKA, "Morek");
            zvire1.RekniCoJsi();
            Zvire zvire2 = new Zvire(Druh.PES, "Hafan");
            zvire2.RekniCoJsi();
            Zvire zvire3 = new Zvire();
            zvire3.RekniCoJsi();
            Zvire zvire4 = new Zvire()
            {
                Jmeno = "Alik",
                Druh = Druh.PES,
            };
            zvire4.RekniCoJsi();
            Console.WriteLine($"Zvire 1: \nJmeno: {zvire1.Jmeno}\nDruh: {zvire1.Druh}");
            zvire2.ToString();
        }
    }
}
