using Microsoft.EntityFrameworkCore;

namespace OrmKata;

[PrimaryKey(nameof(Name))]
public class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDate { get; set; }
}