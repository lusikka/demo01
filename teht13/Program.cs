using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] points = new int[6];
            int worst = 0;
            int best = 0;
            int sum = 0;
            Console.WriteLine("You just performed a successful ski jump. The judges will now award their points.");
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(i + 1 + "# judge gives you how many points? Yeah, you get to pick.");
                string line = Console.ReadLine();
                points[i] = int.Parse(line);
            }
            Console.WriteLine("The sum of the given points: " + (points[0] + points[1] + points[2] + points[3] + points[4]));
            sum = points[0] + points[1] + points[2] + points[3] + points[4];
            if (points[0] <= points[1] && points[0] <= points[2] && points[0] <= points[3] && points[0] <= points[4])
            {
                worst = points[0];
            }
            else if (points[1] <= points[0] && points[1] <= points[2] && points[1] <= points[3] && points[1] <= points[4])
            {
                worst = points[1];
            }
            else if (points[2] <= points[0] && points[2] <= points[1] && points[2] <= points[3] && points[2] <= points[4])
            {
                worst = points[2];
            }
            else if (points[3] <= points[0] && points[3] <= points[1] && points[3] <= points[4] && points[3] <= points[4])
            {
                worst = points[3];
            }
            else if (points[4] <= points[0] && points[4] <= points[1] && points[4] <= points[2] && points[4] <= points[3])
            {
                worst = points[4];
            }
            if (points[0] >= points[1] && points[0] >= points[2] && points[0] >= points[3] && points[0] >= points[4])
            {
                best = points[0];
            }
            else if (points[1] >= points[0] && points[1] >= points[2] && points[1] >= points[3] && points[1] >= points[4])
            {
                best = points[1];
            }
            else if (points[2] >= points[0] && points[2] >= points[1] && points[2] >= points[3] && points[2] >= points[4])
            {
                best = points[2];
            }
            else if (points[3] >= points[0] && points[3] >= points[1] && points[3] >= points[4] && points[3] >= points[4])
            {
                best = points[3];
            }
            else if (points[4] >= points[0] && points[4] >= points[1] && points[4] >= points[2] && points[4] >= points[3])
            {
                best = points[4];
            }
            Console.WriteLine("The lowest points were: " + worst);
            Console.WriteLine("The highest points were: " + best);
            Console.WriteLine("When we take out the lowest and highest points from the total, you will be left with: " + (sum - best - worst));
            Console.WriteLine("Congratulation. Now go do something more worthwhile with your time.");

        }
    }
}
