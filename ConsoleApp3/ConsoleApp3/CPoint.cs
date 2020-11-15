using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    public class CPoint : CGraphicsObject

    {
        public int x1 { set; get; } //поля класса + setter&getter
        public int y1 { set; get; }

        public CPoint(int _x1, int _y1)
        {
           x1 = _x1; y1 = _y1;
        } //конструктор класса
        public void Show()
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
