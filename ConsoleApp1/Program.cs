// See https://aka.ms/new-console-template for more information

using ConsoleApp1.SchoolMethod;
using System.Linq;
using PersonModel;
using System.Data;


var data = DatasetAccess.LoadData(@"C:\MES_DDC_SW\repos\ConsoleApp1\ConsoleApp1\data2024.json");

//var pocet_osob = data.Count();

//Console.WriteLine($"Pocet osob: {pocet_osob}");

//var firstPerson = data.First(); //jedna osoboa (Person), práce se třídou
//Console.WriteLine(firstPerson.Email);

//var take1 = data.Take(1); //kolekce jedné osoby, práce s listem
//foreach (var item in take1) 
//{
//    Console.WriteLine(item.Email);
//}

//var p2 = data.Where(person => person.Email.Equals("Karin.Prochazkova41@gmail.com")).FirstOrDefault();

//if (p2 != null)
//{
//    Console.WriteLine(p2.Email);
//}
//else
//{
//    Console.WriteLine("P2 is null");
//}

data.Where(x => x.Id == 5).SingleOrDefault();

//var g = data.GroupBy(x => x.LastName);
//foreach (var group in g) 
//{
//    var lastName = group.Key;
//    var pocetLidiVeSkupine = group.Count();
//    Console.WriteLine($"{lastName}: {pocetLidiVeSkupine}");


//}

//var nejmladsiOsoba = data.OrderByDescending(x => x.DateOfBirth).First();
//Console.WriteLine(nejmladsiOsoba);

var mesta = data.GroupBy(person => person.Address?.City).OrderByDescending(mesto_kde => mesto_kde.Count()).Take(10).ToList();
foreach (var mesto in mesta) 
{
    
    Console.WriteLine($"{mesto.Key}: {mesto.Count()}");
}
