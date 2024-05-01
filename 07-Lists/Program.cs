using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a list of strings......
            List<int> numbers = new List<int>();
            //Adding elements to list......
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Remove(20);
            bool NumCon = numbers.Contains(10);
            Console.WriteLine("20 number Removed ...." +numbers.Remove(20));
            Console.WriteLine("List Contains (10)= " + NumCon);
            Console.WriteLine($"List has Numbers");
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            
            
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
