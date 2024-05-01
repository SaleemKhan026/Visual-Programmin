using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Structres
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Muhammad Saleem";
            Console.WriteLine("Name: "+name);
            string roll="05";
            Console.WriteLine("Roll number :  "+roll);
            string classname = "5th Semester BScs";
            Console.WriteLine("Class: " +classname);
            //if and else statements::
            //Console.WriteLine("If and Else Statements");
            //Console.WriteLine("Checking driver age:");
            //Console.WriteLine("Enter Your age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //if (age >= 18)
            //{
            //    Console.Write("You can drive.");
            //}
            //else
            //{
            //    Console.WriteLine("You cannot drive now.");


            //     }

            //Switch Conditions::
            //Console.WriteLine("Switch Statement:");
            //Console.WriteLine("Checking days name:");
            //Console.WriteLine("Enter day number i will tell you day name ");
            //Console.WriteLine("Days start from Monday.");
            //int day = Convert.ToInt32(Console.ReadLine());
            //switch (day)
            //{
            //    case 1:Console.Write("Monday");break;
            //    case 2: Console.Write("Tuesday"); break;
            //    case 3: Console.Write("Wednesday"); break;
            //    case 4: Console.Write("Thursday"); break;
            //    case 5: Console.Write("Friday"); break;
            //    case 6: Console.Write("Saturday"); break;
            //    case 7: Console.Write("Sunday"); break;
            //    default: Console.Write("Monday"); break;


            //}
            //Loops
            //For loop
            Console.WriteLine("About For Loop");
            Console.WriteLine("Printing  Multiple Tables:");
            Console.WriteLine("Enter a desired table number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int tab;
            for(int i = 1; i <= 10; i++)
            {
                tab = num * i;
                Console.WriteLine($"{num}*{i} = {tab}");
            }







            Console.ReadLine();
        
        
        }
    }
}
