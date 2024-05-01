using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays Practice");
            //int[] num = {10,20,30,4,50,60 };
            ////Console.WriteLine(num[2]);
            //for(int i=0; i < num.Length; i++)
            //{
      //    Console.WriteLine($"{i} {num[i]}");
            //}
      int[,] num = { { 20, 50, 40 }, { 30, 60, 70 }, { 80, 90, 100 } };
        int sum =0;  
    //Console.WriteLine($" index number {num[0, 2]}");
            for (int i = 0; i <3; i++)
       {
                for (int j = 0; j <3; j++)
                {
              
                     Console.Write(   $"{num[i,j]}"+"\t"); 
                   
         }
               Console.WriteLine();
              
            }
            foreach (int  item in num)
	{
               //  Console.Write($"{item}"); 
               sum+=item;
                 Console.WriteLine($"Adding  one by one result = {sum}");
	}
            Console.WriteLine(   $"Sum of all terms is = {sum}");
                Console.ReadLine();
        }
    }
}
