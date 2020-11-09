using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varijable_vježbe_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 2;
            double b = 2;
            double c = 2;
            double d = 2;
            double x;
            x = (Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2) + Math.Pow(d, 2)) / (Math.Pow(a + b, 2) + Math.Pow(c + d, 2));
            Console.Write(x);
            


        }
    }
}
