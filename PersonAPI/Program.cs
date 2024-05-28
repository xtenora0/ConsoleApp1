using PersonData;
using PersonModel;
using System.Linq;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<PeopleContext>();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("/person/{id}", (int id, PeopleContext db) => db.People.Where(x => x.Id == id).Single());
app.MapGet("/person/searchemail/{email}", (string email, PeopleContext db) => 
    db.People.Where(osoba => osoba.Email.ToLower().Contains(email.ToLower()))
);

app.MapPost("/person/create", (Person person, PeopleContext db) =>
{
    db.People.Add(person);
    db.SaveChanges();
    return person;
});

//update zaznamu v DB
app.MapPut("/person/edit/", (Person person, PeopleContext db) =>
{
    var personDB = db.People.Where(s => s.Id == person.Id).Single();
    
    //personDB.FirstName = person.FirstName; jeden zpusob

    db.Entry<Person>(personDB).CurrentValues.SetValues(person);
    db.SaveChanges();
    return personDB;
});

app.Run();
