using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LR_4._1_Drobnyi
{
    public class triangle : hexagon
    {
        public int h { set; get; }
        public double S2 = 0;
        public triangle(int _a, int _h) : base(_a)
        {
            a = _a; h = _h;
        } //конструктор класса
        new public void Show()
        {
            Console.WriteLine("Предок:" + (this.GetType().BaseType).ToString());
            Console.WriteLine("Объект:" + (this.GetType().Name).ToString());
        }

        new public double Squre()
        {
            S2 = (0.5 * a * h);
            Console.WriteLine("s2 = " + S2.ToString());
            return S2;
        }

        ~triangle()
        {
            Console.WriteLine("Destructor");
        }// деструктор класса
    }
}