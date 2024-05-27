using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;


public class Zvire
{
    public string druh;
    public string jmeno;

    public Zvire(string _druh, string _jmeno) 
    {
        this.druh = _druh;
        this.jmeno = _jmeno; 
    }

    public void RekniCoJsi() 
    {
        Console.WriteLine("Jsem " + druh + " a " + jmeno);
    }
}
