using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name ");
            string name = Console.ReadLine();
            Console.Write("Enter Your Roll No ");
            string rono = Console.ReadLine();
            Console.Write("Enter Your Class Name ");
            string cls = Console.ReadLine();
            Console.WriteLine($"Welcom {name}\nYour name is {name}\nYour Roll No is {rono}\nYor Class is {cls}");


            Console.ReadLine();
        }
    }
}
