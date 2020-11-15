using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coordinates for x1,y1 for CPoint:" );
            CPoint new_point = new CPoint(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            new_point.Show();
            Console.WriteLine("Enter coordinates for x1,y1,x2,y2,x3,y3 for Triangle:");
            Triangle new_triangle = new Triangle(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            new_triangle.Show();
            Console.ReadKey();
        }
    }
}
