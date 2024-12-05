using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace LINQ
{
    class Program
    {
        public class Person {
            public string Name {get; set;}
            public int Age {get; set;}
            public int locationId {get; set;}
        }
        public class Location{
            public int id {get; set;}
            public string Name {get; set;}
        }
       public static void Main(){
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        

            //Filtering
        // var evenNumbers = from n in numbers
        //                   where n % 2 == 0 //query syntax
        //                   select n;

        // var evenNumbers = numbers.Where(n => n % 2 == 0); // method syntax

        // var squares = numbers.Select(n => n * n); // select

        // var orderedNumbers = numbers.OrderByDescending(n => n); //Order
        
        var people = new List<Person>{
        new Person { Name = "Alice", Age = 25, locationId = 1 },
        new Person { Name = "Bob", Age = 30, locationId = 2},
        new Person { Name = "Charlie", Age = 17, locationId = 2 }
        };

        // var adults = people.Where(p => p.Age <= 18).Select(p => p.Name); //filter & select

        // var count = numbers.Count(); //Aggregate function Count

        // foreach (var number in adults){
        //     Console.WriteLine(number);  //output for basic LINQ
        // }
        // Console.WriteLine(count);
        
        //Group Data
        // var groupedByAge = from person in people
        //                    group person by person.Age into ageGroup //Query Syntax
        //                    select ageGroup;

        // var groupedByAge = people.GroupBy(person => person.Age); //Method Syntax

        // foreach (var group in groupedByAge){
        // Console.WriteLine($"Age Group: {group.Key}");   //Output for group data
        //     foreach (var person in group){
        //         Console.WriteLine($" - {person.Name}");
        //         }
        //     }
        var locations = new List<Location>{
        new Location {id = 1, Name = "New York"},
        new Location {id = 2, Name = "London"}
        };

        var locationPeople = from p in people
                             join loc in locations
                             on p.locationId equals loc.id
                             select new {p.Name, Location = loc.Name};

        foreach (var detail in locationPeople){
            Console.WriteLine($"{detail.Name} works in {detail.Location}");
        }
        }
    }
}