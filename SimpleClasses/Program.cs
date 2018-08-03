using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Holden";
            myCar.Model = "Commodore";
            myCar.Year = 2008;
            myCar.Colour = "Blue";

            Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Colour);
            Console.WriteLine("{0:C}",myCar.DetermineMarketValue());

            Console.ReadLine();
        }

    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }
        public decimal DetermineMarketValue()
        {
            decimal carValue;
            if (Year > 1990)
                carValue = 10000;
            else
                carValue = 2000;
            return carValue;
        }


    }
}
