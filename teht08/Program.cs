using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht08
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            Console.WriteLine("I want three numbers. Give me the first number.");
            string line1 = Console.ReadLine();
            num1 = int.Parse(line1);
            Console.WriteLine("Now the second number.");
            string line2 = Console.ReadLine();
            num2 = int.Parse(line2);
            Console.WriteLine("...and the third and final number, please and thank you.");
            string line3 = Console.ReadLine();
            num3 = int.Parse(line3);
            if (num1 > num2 && num1 > num3)
                Console.WriteLine(num1 + " is the biggest one, I think...");
            else if (num2 > num1 && num2 > num3)
                Console.WriteLine(num2 + " is the biggest one, I think...");
            else if (num3 > num1 && num3 > num2)
                Console.WriteLine(num3 + " is the biggest one, I think...");
        }
    }
}
