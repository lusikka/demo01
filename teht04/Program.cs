using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Give me an age: ");
            string line = Console.ReadLine();
            age = int.Parse(line);
            if (age < 18)
                Console.WriteLine("They're illegal!");
            else if (age >= 18 && age <= 65)
                Console.WriteLine("Adult.");
            else if (age > 65)
                Console.WriteLine("Senior citizen.");                   
        }
    }
}
