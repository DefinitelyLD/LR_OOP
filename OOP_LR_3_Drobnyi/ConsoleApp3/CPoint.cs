using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    public class CPoint : CGraphicsObject

    {
  

        public CPoint(int _x1, int _y1)
        {
           x1 = _x1; y1 = _y1;
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
