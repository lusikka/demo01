using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht09
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            Console.WriteLine("Alright, I want numbers again...so sock 'em to me.");
            string line2 = Console.ReadLine();
            num = int.Parse(line2);
            sum = sum + num;
            do
            {
                Console.WriteLine("Okay! Now keep giving me numbers. I like numbers.");
                string line = Console.ReadLine();
                num = int.Parse(line);
                sum = sum + num;
            } while (num > 0);
            Console.WriteLine("Okay. Cool. The sum of the numbers is " + sum + ".");
        }
    }
}
