using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            int sum;
            int average;
            Console.WriteLine("Give the first number: ");
            string line = Console.ReadLine();
            num1 = int.Parse(line);
            Console.WriteLine("Give me the second number: ");
            string line2 = Console.ReadLine();
            num2 = int.Parse(line2);
            Console.WriteLine("Give me the third and final number: ");
            string line3 = Console.ReadLine();
            num3 = int.Parse(line3);
            sum = num1 + num2 + num3;
            average = sum / 3;
            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine("The average is: " + average);
        }
    }
}
