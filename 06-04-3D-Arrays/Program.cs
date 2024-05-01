using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        
            {
                // Declaration and Initialization of a 3-D Array
    int[,,] cube = new int[2, 2, 2] { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };
         // Accessing and printing elements of the 3-D array
          Console.WriteLine("3-D Array Elements:");            
                for (int i = 0; i < 2; i++)
            {
              for (int j = 0; j < 2; j++)
              {
              for (int k = 0; k < 2; k++)
            {
               Console.Write(cube[i, j, k] + " ");
             }
           Console.WriteLine();
                  }
                  Console.WriteLine();
              }
            int max = int.MinValue;
            int min = int.MaxValue;
            int sum = 0;
            foreach (int item in cube)
            {
                if (item > max)
                {
                    max = item;
                }
                if (item < min)
                {
                    min = item;
                }

                //  Console.WriteLine($"{item}");
                sum += item;
            }
            Console.WriteLine($" Maximum is = {max}");
            Console.WriteLine($" Minimum is = {min}");
            Console.WriteLine($" Sum is = {sum}");
      
            Console.ReadLine();   
        }
    }
}
