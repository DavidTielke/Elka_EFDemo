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
            // IEnumerable: Where, OrderBy, ...
            // IQueryable: Where, OrderBy,...

            var query = Database.Context.Set<Person>().Take(2);

            // Executing Functions: ToList(), First(), Last(), Single(), Any(), All(), Max(), Min(), Avg()
            var persons = query.ToList();

            //persons = persons.Take(2).ToList();

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
