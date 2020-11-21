using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    public class CPoint : CGraphicsObject

    {
        public int X1
        {
            get { return x1; }
            set { x1 = value; }
        }
        public int Y1
        {
            get { return y1; }
            set { y1 = value; }
        }


        public CPoint(int _x1, int _y1)
        {
           X1 = _x1; Y1 = _y1;
        } //конструктор класса
        public override void Show()
        {
            Console.WriteLine("Предок:" + (this.GetType().BaseType).ToString());
            Console.WriteLine("Объект:" + (this.GetType().Name).ToString());

        } 

        ~CPoint()
        {
            Console.WriteLine("Destructor");
        }// деструктор класса
    }

}
