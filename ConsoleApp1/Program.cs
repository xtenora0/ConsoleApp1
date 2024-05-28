// See https://aka.ms/new-console-template for more information

using ConsoleApp1.SchoolMethod;
using System.Linq;
using PersonModel;
using System.Data;

//List<string> subjects = new List<string>() {
//    "Maths", "Physics", "Art", "Economy"
//};

//Person s1 = new Student("Lucie", new DateOnly(2000, 12, 04), "304");
//Console.WriteLine(s1);

//Teacher t1 = new Teacher("Pospichal", new DateOnly(1987, 06, 04), subjects);

var data = DatasetAccess.LoadData(@"C:\MES_DDC_SW\repos\ConsoleApp1\ConsoleApp1\data2024.json");

var pocet_osob = data.Count();

Console.WriteLine($"Pocet osob: {pocet_osob}");