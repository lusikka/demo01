using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] table = new int[6];
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("5 numbers this time. Number #" + i + ":");
                string line = Console.ReadLine();
                table[i] = int.Parse(line);
               
            }
            Console.WriteLine("In reverse: " + table[5] + table[4] + table[3] + table[2] + table[1]);

        }
    }
}
