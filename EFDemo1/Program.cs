using System.ComponentModel.DataAnnotations.Schema;
using EFDemo1.Data;
using EFDemo1.DataClasses;
using Microsoft.EntityFrameworkCore;

namespace EFDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var persons = Database.Context.Set<Person>().OrderBy(p => p.Name);

            var erste = persons.First();
            var letzte = persons.Last();
            var zweite = new Person();
            Database.Context.Set<Person>().Add(zweite);
            Database.Context.Set<Person>().Remove(letzte);


            erste.Name = "Foo";
            Console.WriteLine(Database.Context.Entry(erste).State);
            Console.WriteLine(Database.Context.Entry(zweite).State);
            Console.WriteLine(Database.Context.Entry(letzte).State);

            Database.Context.Entry(letzte).State = EntityState.Detached;
            Console.WriteLine(Database.Context.Entry(letzte).State);
            letzte.Name = "Bar";
            Console.WriteLine(Database.Context.Entry(letzte).State);
            Database.Context.Attach(letzte);
            Console.WriteLine(Database.Context.Entry(letzte).State);
            Database.Context.Entry(letzte).DetectChanges();
            Console.WriteLine(Database.Context.Entry(letzte).State);



            foreach (var person in persons)
            {
                var tags = string.Join(",", person.PersonTags.Select(pt => pt.Tag));
                Console.WriteLine($"{person.Name} - {person.Age} - {person.Category.Name} - {tags}");
            }
        }
    }

    static class Database
    {
        public static DbContext Context { get; set; }

        static Database()
        {
            Context = new PeopleContext();
        }
    }
}
