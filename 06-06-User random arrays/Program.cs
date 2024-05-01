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
            Console.WriteLine("Random numbers:");
            Console.Write("Enter starting  Number = ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Enter size of numbers = ");
            int si = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Last Number = ");
            int last = Convert.ToInt32(Console.ReadLine());
            int[] numbers = GenRan(si, num, last);
            Console.WriteLine("Array Elements: = ");
            PrintArray(numbers);
            
           Average(numbers);

            Console.ReadLine();
   }
        static int[] GenRan(int size, int min, int max)
     {
            Random random = new Random();
            int[] numbers = new int[size];
            for (int i = 0;i<size; i++)
            {
                numbers[i] = random.Next(min, max + 1);
               
            }
            return numbers;
      }
         public static int Average(int[] numbers ) { 
             int sum=0;
             double ave = 0;
            foreach (int item in numbers)
	{
                 sum += item;

            return ave =sum/numbers.Length);
	}
            Console.Write($"Sum  is = {sum}\n");
            Console.Write($"Average   is = {ave:F2}\n");

            }
        static void PrintArray(int[] numbers)
      {
            int max = int.MinValue;
            int min=int.MaxValue;
           
           
            foreach (int element in numbers)
            {
             
            
            
                if (element > max)
                {
                    max=element;
                }
                 if (element < min)
                {
                    min = element;
                }
        Console.WriteLine($"{element}");
             
                
            }
           // Console.Write($"Sum  is = {sum}\n");
           //  Console.Write($"Average   is = {ave}\n");
            Console.Write($"Maximum is = {max}\n");
            Console.Write($"Minimum is = {min}");
            Console.WriteLine();
      }

    }
}
