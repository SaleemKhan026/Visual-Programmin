using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_with_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 100,50,55,64,75,86,97,88,59,80,90,75,78,85,15,65};
            Console.Write("Enter index number: = ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<1; i++)
            {
                Console.WriteLine($"Element at index = {n}:{numbers[n]}");
            }
            Console.ReadLine();
        }
    }
}
