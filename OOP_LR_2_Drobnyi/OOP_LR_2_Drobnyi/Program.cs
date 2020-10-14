using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LR_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter base1,base2,height");
            Trapeze new_trapeze = new Trapeze(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("S=" + new_trapeze.Square());
            Console.WriteLine("Setters & getters check:");
            new_trapeze.base1 = 20;
            new_trapeze.base2 = 40;
            new_trapeze.height = 10;
            Console.WriteLine(new_trapeze.base1 + "|" + new_trapeze.base2 + "|" + new_trapeze.height);
            Console.WriteLine("new S=" + new_trapeze.Square());
            Console.ReadKey();


        }
    }
}
