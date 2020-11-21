    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    namespace ConsoleApp3
    {
        public class Triangle : CPoint
        {

            protected int x2; //поля класса 
            protected int y2;

            protected int x3;  //поля класса 
            protected int y3;  

            public int X2 // setter&getter
            {
                get { return x2; }
                set { x2 = value; }
            }
            public int Y2
            {
                get { return y2; }
                set { y2 = value; }
            }

            public int X3
            {
                get { return x3; }
                set { x3 = value; }
            }
            public int Y3
            {
                get { return y3; }
                set { y3 = value; }
            }

        public Triangle(int _x1, int _y1, int _x2, int _y2, int _x3, int _y3) : base(_x1, _y1)
            {
                X1 = _x1; Y1 = _y1; X2 = _x2; Y2 = _y2; X3 = _x3; Y3 = _y3;
        } //конструктор класса

            public override void Show()
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
  
