using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LR_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sh(x^0.5) = " + Math.Sinh(Math.Pow(x, 0.5)));
            Console.ReadKey();
        }
    }
}
