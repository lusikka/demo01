using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            int point;
            int grade = 0;
            Console.WriteLine("How many points: ");
            string line = Console.ReadLine();
            point = int.Parse(line);
            if (point == 0 || point == 1)
                grade = 0;
            else if (point == 2 || point == 3)
                grade = 1;
            else if (point == 4 || point == 5)
                grade = 2;
            else if (point == 6 || point == 7)
                grade = 3;
            else if (point == 8 || point == 9)
                grade = 4;
            else if (point == 10 || point == 11 || point == 12)
                grade = 5;
            else
                Console.WriteLine("Invalid number!!!");
            Console.WriteLine(grade);
        }
    }
}
