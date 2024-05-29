// See https://aka.ms/new-console-template for more information

using ConsoleApp1.SchoolMethod;
using System.Linq;
using PersonModel;
using System.Data;
using PersonData;
using Person = PersonModel.Person;
using System.Net.Http.Json;
using ConsoleApp1;
using ConsoleApp1.Logger;


//var data = DatasetAccess.LoadData(@"C:\MES_DDC_SW\repos\ConsoleApp1\ConsoleApp1\data2024.json");

//var context = new PeopleContext();

//var cnt = context.People.Count();

//Console.WriteLine(cnt);

//Console.WriteLine("Naplnit db? (y/n)");
//var answer = Console.ReadLine();
//if (answer.ToLower() == "y")
//{
//    context.People.AddRange(data);
//    context.SaveChanges();
//    Console.WriteLine("Done");
//}
//else 
//{
//    Console.WriteLine("Skipping");
//}

//var url = "https://localhost:7234";

//HttpClient client = new HttpClient();
//int id = 229;

////GET API
//Person? p = await client.GetFromJsonAsync<Person>($"{url}/person/{id}");

//Console.WriteLine("Zadej hledany mail");

//string mailVstup = Console.ReadLine();
//var email = await client.GetFromJsonAsync<List<Person>>($"{url}/person/searchemail/{mailVstup}");
//foreach (var item in email) 
//{
//    Console.WriteLine(item);
//}

//POST API
//Person p = new() 
//{
//    FirstName = "Pavel1",
//    LastName = "Studený",
//    DateOfBirth = new DateTime(1988,10,20),
//    Email = "pavel.studeny@daikindevice.cz"
//};

//var result = await client.PostAsJsonAsync<Person>($"{url}/person/create", p);
//var personCreated = await result.Content.ReadFromJsonAsync<Person>();
//Console.WriteLine(p);
//p.Email = "novyMail@seznam.cz";

//var result = await client.PutAsJsonAsync<Person>($"{url}/person/edit", p);

//p = await client.GetFromJsonAsync<Person>($"{url}/person/{id}");
//Console.WriteLine(p);

//LegalEntity
//List<LegalEntity> listLE = new() 
//{
//    new LegalEntity()
//    {
//        Id = 0,
//        Name = "Saul Goodman",
//        RegistratonNumber = 2466704,
//    },
//    new LegalEntity()
//    {
//        Id = 0,
//        Name = "Heisenberg",
//        RegistratonNumber = 737000,
//    },
//    new LegalEntity()
//    {
//        Id = 0,
//        Name = "JEJ",
//        RegistratonNumber = 464464,
//    }
//};


//var result1 = await client.PostAsJsonAsync<List<LegalEntity>>($"{url}/legalEntity/create", listLE);
////var poCreated1 = await result1.Content.ReadFromJsonAsync<List<LegalEntity>>();


//var po1 = await client.GetFromJsonAsync<List<LegalEntity>>($"{url}/legalEntity/all");
//foreach (var item in po1) 
//{
//    Console.WriteLine(item);

//}

//----------------------------------------- LOgger + Asynchronní metody, Task, Api
ISimpleLogger logger = new SimpleFileLogger("log.txt");

var data = await PersonAPICall.GetPeople(logger);

Console.WriteLine($"počet osob: {data.Count()}");

Console.ReadLine();
