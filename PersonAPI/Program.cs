using PersonData;
using PersonModel;
using System.Linq;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<PeopleContext>();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("/people/all", (PeopleContext db) =>
{
    Thread.Sleep(200);
    return db.People;
});

app.MapGet("/people/skip/{skip}/take/{take}", (int skip, int take, PeopleContext db) => 
{
    Thread.Sleep(200);
    return db.People.Skip(skip).Take(take);
});

app.MapGet("/person/{id}", (int id, PeopleContext db) => db.People.Where(x => x.Id == id).Single());
app.MapGet("/person/searchemail/{email}", (string email, PeopleContext db) => 
    db.People.Where(osoba => osoba.Email.ToLower().Contains(email.ToLower()))
);

app.MapGet("/people/count", (PeopleContext db) => db.People.Count());

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
//LegalEntity Ukol
app.MapGet("/legalEntity/{id}", (int id, PeopleContext db) => db.LegalEntities.Where(x => x.Id == id).Single());

app.MapPost("/legalEntity/create", (LegalEntity po, PeopleContext db) =>
{
    db.LegalEntities.Add(po);
    db.SaveChanges();
    return po;
});

app.MapPut("/legalEntity/edit/", (LegalEntity po, PeopleContext db) =>
{
    var poDB = db.LegalEntities.Where(s => s.Id == po.Id).Single();

    db.Entry<LegalEntity>(poDB).CurrentValues.SetValues(po);
    db.SaveChanges();
    return poDB;
});

app.MapGet("/legalEntity/all", (PeopleContext db) => db.LegalEntities);

app.Run();

