using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //loops
            //give me sum of all numbers
            Console.WriteLine("Getting sum of all numbers:");
            Console.WriteLine("Enter first number:");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter last number:");
            int l = Convert.ToInt32(Console.ReadLine());
            int sum;
            for ( sum =i ; i<= l; i++)
            {
                sum = i +sum ;
              
                Console.WriteLine(sum);
            }
            Console.ReadLine();
        }
    }
}
