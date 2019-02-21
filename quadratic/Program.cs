using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadratic
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2;
            Console.WriteLine("Enter a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter c");
            c = Convert.ToDouble(Console.ReadLine());

            double Root = Math.Sqrt(b * b - 4 * a * c);
            x1 = (-b - Root) / 2 * a;
            x2 = (-b + Root) / 2 * a;

            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
            Console.ReadLine();

                   
                    
            
        }
    }
}
