using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    delegate void Message(string one, string two); // Объявляем делегат
    interface ITriangle
    {
        void print(); //метод интерфейса
    }
    public class triangle : CGraphicsObject, ITriangle
    {
        Message mes;//Создаем переменную делегата
        private int a;
        public int A
        {
            get { return a; }
            set { a = value; }
        } //поля класса + setter&getter
        private int h;
        public int H
        {
            get { return h; }
            set { h = value; }
        }
        public double S2 = 0;
        public triangle(int _a, int _h) 
        {
            A = _a; H = _h; 
            if (_a > 10){
                mes = reverse;// Присваиваем этой переменной адрес метода
            }
            else
            {
                mes = normal;
            }
            mes("a<10", "a>10"); //Вызываем метод

        } //конструктор класса
        public override void Show()
        {
            Console.WriteLine("Предок:" + (this.GetType().BaseType).ToString());
            Console.WriteLine("Объект:" + (this.GetType().Name).ToString());
        }
        public void print()
        {
            Console.WriteLine("Triangle in Triangle");
        }

        private static void normal(string one, string two)
        {
            Console.WriteLine(one);
        }

        private static void reverse(string one, string two)
        {
            Console.WriteLine(two);
        }
        ~triangle()
        {
            Console.WriteLine("Destructor");
        }// деструктор класса
    }
}