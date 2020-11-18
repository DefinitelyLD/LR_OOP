using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_4._1_Drobnyi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a for hexagon:");
            hexagon new_hexagon = new hexagon(Convert.ToInt32(Console.ReadLine()));
            new_hexagon.Show();
            new_hexagon.ClassName();
            new_hexagon.Squre();
            Console.WriteLine("Enter a,h for triangle:");
            triangle triangle = new triangle(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            triangle.Show();
            triangle.ClassName();
            triangle.Squre();
            bool result = new_hexagon.S1 >= triangle.S2;
            Console.WriteLine("s1 >= s2:" + result.ToString());
            Console.ReadKey();
        }
    }
}
