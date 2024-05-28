using Microsoft.EntityFrameworkCore;
using PersonModel;

namespace PersonData;

public class PeopleContext : DbContext
{
    public DbSet<Person> People { get; set; }

    public DbSet<Address> Addresses { get; set; }

    public DbSet<Contract> Contracts { get; set; }
    public DbSet<LegalEntity> LegalEntities { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite(@"Data Source=C:\MES_DDC_SW\repos\ConsoleApp1\people.db");
    
}
