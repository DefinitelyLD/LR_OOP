    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    namespace ConsoleApp3
    {
        public class Triangle : CPoint
        {
     
            public int x2 { set; get; } //поля класса + setter&getter
            public int y2 { set; get; }

            public int x3 { set; get; } //поля класса + setter&getter
            public int y3 { set; get; }


            public Triangle(int _x1, int _y1, int _x2, int _y2, int _x3, int _y3) : base(_x1, _y1)
            {
                x1 = _x1; y1 = _y1;
            } //конструктор класса

            new public void Show()
            {
                Console.WriteLine("Предок:" + (this.GetType().BaseType).ToString());
                Console.WriteLine("Абстрактный класс:" + (this.GetType().BaseType).BaseType.ToString());
                Console.WriteLine("Объект:" + (this.GetType().Name).ToString());
            }


            ~Triangle()
            {
                Console.WriteLine("Destructor");
            }// деструктор класса
        }

    }
  
