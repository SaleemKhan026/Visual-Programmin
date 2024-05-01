
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method__01
{
    class Program
    {
        public static void detail(string name,string roll)
        {
            Console.WriteLine($"Name = {name}");
            Console.Write($"Roll No = { roll}");
        }
        static void Main(string[] args)
        {
           detail("MUHAMMAD SALEEM","05");
            Console.ReadLine();
        }

    }
}
