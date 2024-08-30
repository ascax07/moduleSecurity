using System;
using System.Threading.Tasks;

namespace PersonaApp
{
    internal class program
    {
        static void Main(string[] args)
        {
            var Williams = new Person("Williams");
            var juan = new Person("juan");
            Williams.Speak();
            juan.Speak();
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
            Console.WriteLine($"My name is {Name}");


        }

    }

}