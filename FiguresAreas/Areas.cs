using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresAreas
{
    public class Areas
    {
        public static double TriangleArea(double a, double b, double c)
        {
            if (a > 0.0 && b > 0.0 && c > 0.0)
            {
                if (a == b && a == c)
                {
                    double num = a * Math.Sqrt(3.0) / 2.0;
                    return 0.5 * a * num;
                }

                double num2 = (a + b + c) / 2.0;
                return Math.Sqrt(num2 * ((num2 - a) * (num2 - b) * (num2 - c)));
            }

            return -1.0;
        }

        public static double CircleArea(double r)
        {
            if (r > 0.0)
            {
                return Math.PI * Math.Pow(r, 2.0);
            }

            return -1.0;
        }
    }
}
