using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec;
            Console.WriteLine("Give me time in seconds: ");
            string line = Console.ReadLine();
            sec = int.Parse(line);
            TimeSpan t = TimeSpan.FromSeconds(sec);
            Console.WriteLine("Hours: " + t.Hours + ", Minutes: " + t.Minutes + ", Seconds: " + t.Seconds);

        }
    }
}
