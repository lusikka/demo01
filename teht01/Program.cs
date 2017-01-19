using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask a number
            int num;
            Console.WriteLine("Give me a number, fool");
            string line = Console.ReadLine(); // "1"
            num = int.Parse(line); // "1" -> 1
            // check which number
            switch(num)
            {
                case 1: Console.WriteLine("Yksi. One.");
                    break;
                case 2: Console.WriteLine("Kaksi. Two.");
                    break;
                case 3: Console.WriteLine("Kolme. Three.");
                    break;
                default: Console.WriteLine("Not a valid number.");
                    break;
            }

        }
    }
}
