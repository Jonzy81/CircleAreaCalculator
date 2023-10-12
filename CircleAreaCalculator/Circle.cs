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
       public int Radius { get; private set; }
        public Circle (int radius)
        {
            Radius = radius;
        }
        public double GetRadius()
        {
            double areaCircle= Math.PI*Math.Pow(Radius,2);
            double areaSphere = 4 * Math.PI * Math.Pow(Radius, 2);
            Console.WriteLine($"Arean för cirkeln med radien {Radius}cm är {areaCircle:0.00} cm i kvadrat, " +
                $"\nifall du undrar så är arean av cirkeln ifall den vore en sfär {areaSphere:0.00} cm i kvadrat\n");
            return areaCircle;
        }
    }
}
