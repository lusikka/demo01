using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht07
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Give me a year: ");
            string line = Console.ReadLine();
            year = int.Parse(line);
            if (year % 4 == 0 && year % 400 == 0)
                Console.WriteLine("It's a leap year! ~ ^^;;");
            else
                Console.WriteLine("It's not a leap year...");
        }
    }
}