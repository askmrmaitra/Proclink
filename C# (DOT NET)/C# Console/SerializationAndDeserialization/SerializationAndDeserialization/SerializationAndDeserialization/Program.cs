

using System.Text.Json;
using System.ComponentModel.Design.Serialization;
//using Newtonsoft.Json;

namespace SerializationAndDeserialization
{
    public class Person
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        
    }

   
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialize a List of Person
            List<Person> people = new List<Person>() {
                new Person{ Name="Amit Sharma",Phone="9874556662600"},
                new Person{Name="Sneha Singh",Phone="9549656666232"},
                new Person{Name="Rajesh Kumar",Phone="454545454"},
                new Person{Name="Aman Vishwakarma",Phone="6565656565"},
                new Person{Name="Srikant",Phone="9874698746"}
            };

            #region Serialization and Deserialization with Newtonsoft


            ////Serializing the List
            //string jsonPerson = JsonConvert.SerializeObject(people);
            //Console.WriteLine("Converted JSON Data");
            //Console.WriteLine(jsonPerson);

            //////Deserialize the Data
            //var deserializedJson = JsonConvert.DeserializeObject<List<Person>>(jsonPerson);
            //Console.WriteLine("Deserialized Data");
            //if (deserializedJson != null)
            //{
            //    foreach (var person in deserializedJson)
            //    {
            //        Console.WriteLine($"Name:{person.Name} and Phone:{person.Phone}");
            //    }
            //}


            #endregion

            #region Serialization and Deserialization with System.Text.JSon

            //Serialization 
            //string convertedJson = JsonSerializer.Serialize(people);
            //Console.WriteLine("Converted JSON Data");
            //Console.WriteLine(convertedJson);

            //Console.WriteLine("\n\n\n");
            ////Deserialize the Data
            //var deserializedJson = JsonSerializer.Deserialize<List<Person>>(convertedJson);
            //Console.WriteLine("Deserialized Data");
            //if (deserializedJson != null)
            //{
            //    foreach (var person in deserializedJson)
            //    {
            //        Console.WriteLine($"Name:{person.Name} and Phone:{person.Phone}");
            //    }
            //}
            #endregion


            Console.ReadKey();
        }
    }
}
