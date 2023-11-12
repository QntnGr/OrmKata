using OrmKata;
using System.Reflection.Metadata;

using var db = new PersonContext();
// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Database path: {db.DbPath}.");



// Insert
Console.WriteLine("Inserting a new blog");
db.Add(new Person { Name = "George", Surname = "Abitbol" });
db.SaveChanges();
Console.ReadKey();

// Read
Console.WriteLine("Querying for a blog");
var person = db.Persons
    .OrderBy(b => b.Name)
    .First();
Console.ReadKey();

// Update
Console.WriteLine("Updating the blog and adding a post");
person.Name = "George";
person.Surname = "NewName";
db.SaveChanges();
Console.ReadKey();

// Delete
//Console.WriteLine("Delete the blog");
//db.Remove(person);
//db.SaveChanges();

