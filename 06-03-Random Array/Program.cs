using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Array
{
    class Program
    {
     
        static void Main(string[] args)
        {
            Console.WriteLine("Random numbers 10:");
            int[] numbers = GenRan( 10, 1, 100 );
            Console.WriteLine("Array Elements: ");
            Print(numbers);
            Console.ReadLine();
        }

        static int[] GenRan(int size,int min,int max)
        {
            Random random = new Random();
            int[] numbers = new int[size];
            for(int i=0; i < size; i++)
            {
                numbers[i] = random.Next(min, max + 1);
            }
            return numbers;
            }

        static void Print(int[] numbers)
        {
            foreach(int element in numbers)
            {
                Console.WriteLine($"{element}");
            }
            Console.WriteLine();
        }
    }
}
