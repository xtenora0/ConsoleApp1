// See https://aka.ms/new-console-template for more information

using ConsoleApp1.SchoolMethod;
using System.Linq;
using PersonModel;
using System.Data;
using PersonData;


var data = DatasetAccess.LoadData(@"C:\MES_DDC_SW\repos\ConsoleApp1\ConsoleApp1\data2024.json");

var context = new PeopleContext();

var cnt = context.People.Count();

Console.WriteLine(cnt);

Console.WriteLine("Naplnit db? (y/n)");
var answer = Console.ReadLine();
if (answer.ToLower() == "y")
{
    context.People.AddRange(data);
    context.SaveChanges();
    Console.WriteLine("Done");
}
else 
{
    Console.WriteLine("Skipping");
}