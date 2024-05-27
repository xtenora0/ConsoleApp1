// See https://aka.ms/new-console-template for more information

using ConsoleApp1.SchoolMethod;
using System.Linq;

List<string> subjects = new List<string>() {
    "Maths", "Physics", "Art", "Economy"
};

Person s1 = new Student("Lucie", new DateOnly(2000, 12, 04), "304");
Console.WriteLine(s1);

Teacher t1 = new Teacher("Pospichal", new DateOnly(1987, 06, 04), subjects);