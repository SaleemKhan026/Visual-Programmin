using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            byte nyte = 255;
            Console.WriteLine($"One Byte  Ranges = {nyte}");
            sbyte  n2byte= -128;
            Console.WriteLine($"One sByte negative Ranges = {n2byte}");
            sbyte n3byte = 127;
            Console.WriteLine($"One sByte positive Ranges = {n3byte}");
            ushort us1short = 65535;
            Console.WriteLine($"Ushort ranges =  {us1short}");
           short s1short = 32767;
            Console.WriteLine($"One short positive Ranges = {s1short}");
            short s2short = -32768;
            Console.WriteLine($"One short negative  Ranges = {s2short}");
            int a = 2147483647;
            Console.WriteLine($"Inter positive value = {a}");
            int ab = -2147483648;
            Console.WriteLine($"Inter negative value = {ab}");
            uint aa = 4294967295;
            Console.WriteLine($"Inter unsigned value = {aa}");

            Console.ReadLine();
        }
    }
}
