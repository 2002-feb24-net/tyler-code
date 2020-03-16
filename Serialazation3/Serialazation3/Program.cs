using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Serialazation3
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string filePath = "data7.json";
            List<Person> data = null;

            if (!File.Exists(filePath))
            {
                string json1 = ConvertToJson(data);
                data = FillList();

                try
                {
                    await WriteFileAsync2(json1, filePath);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                string json2 = ConvertToJson(data);

                JsonSerializer.Deserialize<List<Person>>(json2);
            }
        }

        private static async Task WriteFileAsync2(string text, string filePath)
        {
            FileStream file = null;
            try
            {
                file = new FileStream(filePath, FileMode.Create);
                byte[] data = Encoding.UTF8.GetBytes(filePath);
                await file.WriteAsync(data);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Fatal error");
                Console.WriteLine(ex.Message);
                return;
            }

            if(file != null)
            {
                file.Close();
            }


        }

        private static string ConvertToJson(List<Person> data)
        {
            return JsonSerializer.Serialize(data);
        }

        static List<Person> FillList()
        {
            //1st declare the list of Objects
            var listOfList = new List<Person>();
            //2nd make x amount of the objects
            var person1 = new Person();
            //Populate the properties in the class
            person1.Name = "Tyler";
            person1.ID = 1;

            var person2 = new Person();
            person2.Name = "Tristan";
            person2.ID = 2;

            var person3 = new Person();
            person3.Name = "Lisa";
            person3.ID = 3;
            person3.Children = new List<Person>
                {
                    new Person
                    { Name = "Brie", ID = 4, Children = new List<Person>
                        {
                            new Person { Name = "A", ID = 5},
                            new Person { Name = "B", ID = 6},
                            new Person {Name = "C", ID = 7},

                        }
                    }
                };

            listOfList.Add(person1);
            listOfList.Add(person2);
            listOfList.Add(person3);

            return listOfList;
        }
    }
}

//Make a file path with data.json4
//Make a List of the class you created

