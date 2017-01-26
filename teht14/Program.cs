using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht14
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int zero = 0, one = 0, two = 0, three = 0, four = 0, five = 0;
            Console.WriteLine("The students need their grades. Give me numbers from 1 to 5! When your done, give me a 6.");
            do
            {
                Console.WriteLine("Give me a number!");
                string line = Console.ReadLine();
                num = int.Parse(line);
                if (num == 0)
                    zero++;
                else if (num == 1)
                    one++;
                else if (num == 2)
                    two++;
                else if (num == 3)
                    three++;
                else if (num == 4)
                    four++;
                else if (num == 5)
                    five++;

            } while (num != 6);
            Console.WriteLine("");
            Console.Write("0: ");
            for (int i = 0; i < zero; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            Console.Write("1: ");
            for (int i = 0; i < one; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            Console.Write("2: ");
            for (int i = 0; i < two; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            Console.Write("3: ");
            for (int i = 0; i < three; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            Console.Write("4: ");
            for (int i = 0; i < four; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            Console.Write("5: ");
            for (int i = 0; i < five; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }           
    }
}
