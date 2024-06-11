using System.ComponentModel.DataAnnotations.Schema;
using EFDemo1.Data;
using EFDemo1.DataClasses;

namespace EFDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var database = new PeopleContext();

            var people = database.Set<Person>().ToList();

            foreach (var person in people)
            {
                var tags = string.Join(",", person.PersonTags.Select(pt => pt.Tag.Name));
                Console.WriteLine($"{person.Id} - {person.Name} - {person.Age} - {person.Category.Name} - {tags}");
            }
        }
    }
}
