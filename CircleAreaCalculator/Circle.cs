using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CircleAreaCalculator
{
    internal class Circle
    {
        int _radius;
        public Circle (int radius)
        {
            _radius = radius;
        }
        public double GetRadius(int radius)
        {
            double areaCircle= Math.PI*Math.Pow(radius,2);
            double areaSphere = 4 * Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Arean för cirkeln med radien {radius}cm är {areaCircle:0.00} cm i kvadrat, " +
                $"\nifall du undrar så är arean av cirkeln ifall den vore en sfär {areaSphere:0.00} cm i kvadrat\n");
            return areaCircle;
        }
    }
}
