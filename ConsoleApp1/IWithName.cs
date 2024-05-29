using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IWithName
    {
        string Name { get; }
    }

    class Person : IWithName
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class LegalEntity : IWithName 
    {
        public int Id { get; set; }
        public string Name { get => "Firma"; }

    }
}
