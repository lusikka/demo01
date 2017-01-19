using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            double liter;
            double cost;
            double dist;
            Console.WriteLine("Give me a distance: ");
            string line = Console.ReadLine();
            dist = double.Parse(line);
            liter = (dist / 100) * 7.02;
            cost = liter * 1.595;
            Console.WriteLine("Fuel will net you " + cost + " dollers, and you will have used " + liter + " liters of fuel you fucker. :^)");
            Console.WriteLine("Do you really think your fat lazy city dog would take the short walk by foot instead of taking his car, to buy his cigs by choice? Just to save the lives of thousands of mothers and children, who had to die for your fucking gas?");

        }
    }
}
