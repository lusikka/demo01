using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht11
{
    class Program
    {
        static void Main(string[] args)
        {
            int len;
            Console.WriteLine("I'm back, bitch. I desire your numbers once again.");
            string line = Console.ReadLine();
            len = int.Parse(line);
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(" ");
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
            }

        }
    }
}
