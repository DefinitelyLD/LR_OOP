using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LR_4._1_Drobnyi
{
    public class triangle : hexagon
    {
        private int h;
        public int H
        {
            get { return h; }
            set { h = value; }
        }
        public double S2 = 0;
        public triangle(int _a, int _h) : base(_a)
        {
            A = _a; H = _h;
        } //конструктор класса
        public override void Show()
        {
            Console.WriteLine("Предок:" + (this.GetType().BaseType).ToString());
            Console.WriteLine("Объект:" + (this.GetType().Name).ToString());
        }

        public override double Square()
        {
            S2 = (0.5 * A * H);
            Console.WriteLine("s2 = " + S2.ToString());
            return S2;
        }

        ~triangle()
        {
            Console.WriteLine("Destructor");
        }// деструктор класса
    }
}