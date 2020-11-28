using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;



namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a, name for hexagon:");
            hexagon new_hexagon = new hexagon(Convert.ToInt32(Console.ReadLine()),Console.ReadLine());
            new_hexagon.Show();
            new_hexagon.hexagon_name();
            Console.WriteLine("\n" + "Enter a,h for triangle:");
            triangle triangle = new triangle(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            triangle.Show();
            ArrayList objectList = new ArrayList() { new_hexagon, triangle }; //создаем колекцию экземпляров классов наследников
            foreach (object o in objectList) // выводим элементы коллекции
            {
                Console.WriteLine("\n" + o);
            }

            Console.ReadKey();
        }
    }
}
