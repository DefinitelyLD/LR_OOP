using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LR_4._1_Drobnyi
{
    public class hexagon : CGraphicsObject
    {
        public int a { set; get; } //поля класса + setter&getter
        public double S1;
        public hexagon(int _a)
        {
            a = _a;

        } //конструктор класса

        public void Show() //метод вывода информации об объекте
        {
            Console.WriteLine("Предок:" + (this.GetType().BaseType).ToString());
            Console.WriteLine("Абстрактный класс:" + (this.GetType().BaseType).BaseType.ToString());
            Console.WriteLine("Объект:" + (this.GetType().Name).ToString());
        }
        public virtual void ClassName()
        {
            Console.WriteLine("Имя:" + (this.GetType().Name).ToString());
        }
        public double Squre() //метод вычисления площади
        {
            S1 = ((3 * Math.Sqrt(3) * Math.Pow(a, 2)) / 2);
            Console.WriteLine("s1 = " + S1.ToString());
            return S1;
        }

        public static bool operator >=(hexagon S1, triangle S2) //перегрузка оператора
        {
            return S1 >= S2;
        }

        public static bool operator <=(hexagon S1, triangle S2)
        {
            return S1 <= S2;
        }


        ~hexagon()
        {
            Console.WriteLine("Destructor");
        }// деструктор класса
    }

}
