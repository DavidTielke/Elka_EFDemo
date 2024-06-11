﻿using System.ComponentModel.DataAnnotations.Schema;
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
                Console.WriteLine($"{person.Id} - {person.Name} - {person.Age} - {person.Category.Name}");
            }
        }
    }
}