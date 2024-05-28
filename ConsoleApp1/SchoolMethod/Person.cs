using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SchoolMethod
{
    internal class Person
    {
        public string Name { get; set; }
        public DateOnly DateOfBirth { get; set; }

        public Person(string name, DateOnly dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }

        public override string ToString() 
            => $"Name: {Name}, DateOfBirth:{DateOfBirth.ToString("dd.MM.yyyy")}";

    }
}
//Main
//List<string> subjects = new List<string>() {
//    "Maths", "Physics", "Art", "Economy"
//};

//Person s1 = new Student("Lucie", new DateOnly(2000, 12, 04), "304");
//Console.WriteLine(s1);

//Teacher t1 = new Teacher("Pospichal", new DateOnly(1987, 06, 04), subjects);
