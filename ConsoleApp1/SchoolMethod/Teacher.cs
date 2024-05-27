using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SchoolMethod
{
    internal class Teacher : Person
    {
        public List<string> Subjects { get; set; }

        public Teacher(string name, DateOnly dateOfBirth, List<string> sub) : base(name, dateOfBirth) 
        {
            Subjects = sub;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $" Classroom: {string.Join(", ", Subjects)}";
        }
    }
}
