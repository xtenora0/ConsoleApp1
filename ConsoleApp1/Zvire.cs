using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;


public class Zvire
{
    public Enum Druh { get; set; }
    public string Jmeno { get; set; }

    public Zvire()
    {
        
        this.Jmeno = "Jsem jen proste jen defaultni zvire";
    }

    public Zvire(Druh druh, string jmeno) 
    {
        this.Druh = druh;
        this.Jmeno = jmeno; 
    }
    public void RekniCoJsi() 
    {
        Console.WriteLine("Jsem " + Druh + " a " + Jmeno);
    }
    public override string ToString()
    {
        return $"Zvire z ToString, jmeno: {Jmeno}, druh: {Druh}";
    }
}

public enum Druh 
{
    DEFAULTDRUH,
    KOCKA,
    PES
}
