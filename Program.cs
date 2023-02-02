using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApplication1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            double solution = 7 * Math.Pow(x, 2) + 3 * x + 6;
            Console.WriteLine("y = " + solution);
            Console.ReadLine();
        }
    }
}
