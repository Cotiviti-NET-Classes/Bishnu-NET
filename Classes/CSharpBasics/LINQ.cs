// Language Integrated Query
using System;
using System.Collections.Generic;
using System.Linq;
using XYZ;

class LINQ
{
    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 34, 23, 67, 56, 21, 43, 54 };
    string[] names = { "Bishnu", "Jidesh", "Nabin", "Nirmal", "Hitesh", "Dipesh", "Hari" };
    
    List<Person> people = new()
    {
        new Person { Name = "Bishnu", Age = 78, Gender = 'M'},
        new Person { Name = "Hari", Age = 7, Gender = 'M'},
        new Person { Name = "Dipesh", Age = 8, Gender = 'M'},
        new Person { Name = "sdfsdf", Age = 56, Gender = 'F'},
        new Person { Name = "ghfgh", Age = 100, Gender = 'F'},
        new Person { Name = "wqrqr", Age = 34, Gender = 'M'},
        new Person { Name = "nvbc", Age = 10, Gender = 'M'}
    };

    public void LearnLinq()
    {
        var hasNameStartingWithA = names.Any(x => x.StartsWith("A"));
        var evenNumbers = numbers.Where(x => x % 2 == 0);
        var squares = numbers.Select(x => x * x);

        evenNumbers = from x in numbers
                      where x % 2 == 0
                      select x;

        var namesHasiinit = names.All(x => x.Contains("i"));

        var items = numbers.Skip(5).Take(5);
        var av = numbers.OrderByDescending(x => x);

        var peopleStartingWithG = people.Where(x => x.Name.ToUpper().StartsWith("G"));
        var orderedPeople = people.OrderBy(x => x.Age);

        foreach (var num in items)
            Console.WriteLine(num);
    }
}