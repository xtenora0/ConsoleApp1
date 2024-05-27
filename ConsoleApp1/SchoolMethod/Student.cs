using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SchoolMethod
{
    internal class Student : Person
    {
        public string ClassRoom { get; set; }

        public Student(string name, DateOnly dateOfBirth, string classRoom) : base(name, dateOfBirth) 
        {
            ClassRoom = classRoom;
        }

        public override string ToString()
        {
            return base.ToString() + $" Classroom: {ClassRoom}";
        }
    }
}
