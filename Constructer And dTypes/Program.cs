using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructer_And_dTypes
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Parameterless Constructor
        public Person()
        {
            Console.WriteLine("Parameterless constructor called.");
            Name = "Unknown";
            Age = 0;
        }
        // One Parameterless Constructor
        public Person(string name)
        {
            Console.WriteLine("One Parameter constructor called.");
            Name = name;
            Age = 0;
        }


        // Two Parameterized Constructor
        public Person(string name, int age)
        {
            Console.WriteLine("Two Parameters constructor called.");
            Name = name;
            Age = age;
        }

          // Copy Constructer..
          // .Stores Copy of another constructor
        public Person(Person otherPerson)
        {
            Console.WriteLine("Copy constructor called.");
            Name = otherPerson.Name;
            Age = otherPerson.Age;
        }
        // Method to display person details
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
        static void Main(string[] args)
        {
            // Constructors
            // Automatically invoked when an object is created .

            // Parameterless Constructor
     Console.WriteLine("Creating person using parameterless constructor:");
            Person person = new Person();
            person.DisplayDetails();
            Console.WriteLine();

            // One Parameterless Constructor
    Console.WriteLine("Creating person using one  parameter constructor:");
            Person person1 = new Person("SALEEM");
            person1.DisplayDetails();
            Console.WriteLine();

            // Parameterized Constructor
            Console.WriteLine("Creating person using two parameters constructor:");
          Person person2 = new Person("SALEEM", 20);
          person2.DisplayDetails();
            Console.WriteLine();
            // Copy Constructor
            // Keeps the cpy of another constructer...
    Console.WriteLine("Keeps the copy of another constructor:");
            Person person3 = new Person(person2);
            person3.DisplayDetails();
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}


