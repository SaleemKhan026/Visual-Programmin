using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_And_Delegates
{
    class Program
    {
        // Step no 1..
        // Declering Delagates
        public delegate void PriceChangedEventHandler(decimal oldPrice, decimal newPrice);

        // Stock class representing a stock market ticker
        class Stock
        {

            // Event declaration for price changed event
            public event PriceChangedEventHandler PriceChanged;

            // Private field for storing the stock price
            private decimal _price;
            public decimal Price
            {
                get { return _price; }
                set
                {
                    if (_price != value)
                    {
                        decimal oldPrice = _price;
                        _price = value;
                        // Raise the PriceChanged event
                        //   OnPriceChanged(oldPrice, _price);
                    }
                }
            }
       
                // Constructor
 public Stock(decimal initialPrice)
            {
                _price = initialPrice;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("About Delegates:");








            Console.ReadLine();
        }
    }
}
