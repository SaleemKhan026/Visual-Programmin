using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Method
{
    class s
    {
        public  int Add(int a ,int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter firts number: = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter firts number: = ");
            int b = Convert.ToInt32(Console.ReadLine());
            s add = new s();
           int sum = add.Add(a,b);
            Console.WriteLine($"Sum is = {sum}");
            int g= add.Add(a, b);
            Console.WriteLine($"Sum2 is = {g}");
            Console.ReadLine();
        }
    }
}
