using System;
using System.Linq;

namespace Serializateion4
{
    class Program
    {
        static void Main(string[] args)
        {
            //we have a desire to keep data persistent while the program is not running
            // or maybe to share the same dabases across multiple copies of the running program

            //one way we can echieve this is with serialization to files we could like code last week, with XML, JSON
            // it's really slow: to change one thing, I have to load the whole file, deserialize the whole file
            //reuslize the whole thing, and write it back to disk

            //1 way to store data: C# objects reference types , value types, fields/ propeprites have object to object
            //refereences.. collectinos. (persistent, but akward)
            //way 2 is serialization XML, JSON
            //Way 3 relational databases (SQL databases)
            // it's persisent, but it's a very well optimezed for queries data without having to load
            //anything beyound exactly to data you want, optimzed for making changes quickly

            //how relations databases treat data, what are the basic building blocks
            //ables, rows, and columns
            //one table for each kind of data
            //a table has one column for each properite that kind of data can have
            //each row has some value for each column, because it represesents one instancne of that kind of data

            //because table, rows, and columns are quite different to how C# represents objects
            //just like how we need a serializtion library
            //we'll use somehing called an ORM

            //in .NET, the main ORM is Enity framework
            //.NET framework we're up to EF 6
            //in .core we're up to  Core 3.1


            //EF Core comes from Microsoft, but it isn't part of CoreFX
            //it's a handful of other assemblies, adn .NET core let's use Nuget to automatically mangae

            //any dependies like that which we need to download and had connected to our onw assembies
            //eso the CLR can run them
            //in the commadnline we use dotnet 

            //to connenct to DB you need an instance of your context class
            //it's very much IDisposable
            using (var conext = new PersonContext())
            {
                //quick and dirty way to create the DB with all it' table, rows, columns
                //which the context expects to se, buf it eh DB already exists does nothing
                conext.Database.EnsureCreated();
                //watch out, if you cahge the structure of the objects you contex use
                //the EF ngiht full at runtime delete you the db file to fix thiswith a new database)

                //if there are no persons , then add the itinal data
                if(conext.Persons.Any())
                {
                    var person = new Person
                    {
                        ID = 1,
                        Name = "Fred"

                    };

                    conext.Persons.Add(person);

                    // to apply the changes that you've prepper on this context instance
                    conext.SaveChanges();
                }
                //regardless , modify fred's name
                var fred = conext.Persons.First(p => p.Name == "Fred");
                Console.WriteLine(fred.Name);
                fred.Name += "+";

                //EF tracks the object you extract from it
                //and my chagnes you make to those objects it will pick up on and apply with SaveChangse
                //
                conext.SaveChanges();
            }

        }
    }
}
