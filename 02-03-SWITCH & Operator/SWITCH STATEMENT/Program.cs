using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWITCH_STATEMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Use of  Switch:");
           
            Console.WriteLine("Enter First Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int b = Convert.ToInt32(Console.ReadLine());
            int op,div,sum,sub,pro;
            Console.WriteLine("Chose Your Method:");
            Console.WriteLine("1 = Division");
            Console.WriteLine("2 = Multiplication");
            Console.WriteLine("3 = Addition");
            Console.WriteLine("4 = Subtraction");
            Console.WriteLine("5 = All Methods");
            Console.WriteLine("Enter number:");
            op = Convert.ToInt32(Console.ReadLine());
            div = a / b;
            pro = a * b;
            sum = a + b;
            sub = a - b;
            switch (op)
            {

              case 1:Console.WriteLine("Division of two numbers is = " + div);break;
              case 2: Console.WriteLine("Multiplication of two numbers is = " + pro); break;
              case 3: Console.WriteLine("Addition of two numbers i s= " + div); break;
              case 4: Console.WriteLine("Subtraction of two numbers is = " + div); break;
         //  case 5:Console.WriteLine($"Division is={div}" +$"product is={pro}"+ $"Sum is={sum}"+ $"Sub is{sub}");break;
             case 5:
             Console.WriteLine("Division of two numbers is = " + div);
             Console.WriteLine("Multiplication of two numbers is = " + pro);
             Console.WriteLine("Addition of two numbers is = " + div);
             Console.WriteLine("Subtraction of two numbers is = " + div);break;
             default: Console.WriteLine("Invalid Number");break;

            }
            Console.ReadLine();
        }
    }
}
