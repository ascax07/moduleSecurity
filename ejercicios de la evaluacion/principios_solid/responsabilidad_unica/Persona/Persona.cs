using System;

namespace PersonaApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var williams = new Person("Williams");
            var juan = new Person("Juan");
            
            williams.Speak();
            juan.Speak();

            var database = new Database();
            database.SaveToDatabase(williams);
        }
    }

    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public void Speak()
        {
            Console.WriteLine($"mi nombre  es {Name}");
        }
    }

    public class Database
    {
        public void SaveToDatabase(Person person)
        {
            Console.WriteLine($"Saved {person.Name}");
        }
    }
}
