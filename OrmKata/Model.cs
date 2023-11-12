using Microsoft.EntityFrameworkCore;

namespace OrmKata;

public class PersonContext :DbContext
{
    public DbSet<Person> Persons { get; set; }
    public string DbPath { get; }
    public PersonContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "persons.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}
