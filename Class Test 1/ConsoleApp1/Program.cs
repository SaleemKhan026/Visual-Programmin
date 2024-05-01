using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        class Book
        {
            public int number { get; set; }
            public string title { get; set; }
            public int price { get; set; }
            public int pages { get; set; }
            public Book()
            {
                Console.WriteLine("Parameterless Constructor Called");
                title = "unknown";
                price = 0;
                
            }
            public Book(string titl)
            {
                Console.WriteLine("One Parameter Constructor Called");

                title = "Unknown";
                price = 560;
            }
            public Book(string name,int pric)
            {
                Console.WriteLine("Two Parameters Constructor Called");
                title = name;
                price = pric;
            }

              public Book(int num,string tit,int pri,int pag)
            {
               // Console.WriteLine("Four Parameters Constructor Called");
                title=tit;
                number=num;
                pages=pag;
                price = pri;
            }
            public Book(Book b2)
            {
                Console.WriteLine("Copy Constructor Called");
                title = b2.title;
                price = b2.price;
            }
            public void DisplayDetails()
            {
                Console.WriteLine($"Name: {title}\nPrice: {price}\nPages: {pages}\nNumber: {number}");
            }


        }

        static void Main(string[] args)
        {
            //Parameterless
            Book b = new Book();
          b.DisplayDetails();
            Console.WriteLine();
            //One Parameter
            Book b1 = new Book("C#") ;
            b1.DisplayDetails();
            Console.WriteLine();
            //Two Parameterlized
            Book b2 = new Book("C#",560);
            b2.DisplayDetails();
            Console.WriteLine();
            //Copy Constructor

            Book b3 = new Book(b2);
            b3.DisplayDetails();
            Console.WriteLine();
            //Displaying details
            Console.WriteLine("Displaying Book Details");
            Book b4 = new Book(78787,"visual Programming",670,550);
            b4.DisplayDetails();

            Console.ReadLine();
        }
    }
}
