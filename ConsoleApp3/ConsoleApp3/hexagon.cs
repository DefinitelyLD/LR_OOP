using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    delegate void Example(int one); // Объявляем делегат
    interface IHexagon
    {
        string Name 
        {
            get; set;
        }
        void hexagon_name();//метод интерфейса
    }

    public class hexagon : CGraphicsObject , IHexagon
    {
        Example ex; //Создаем переменную делегата
        public string Name { get; set; }
        private int a;
        public int A
        {
            get { return a; }
            set { a = value; }
        } //поля класса + setter&getter

        public double S1;
        public hexagon(int _a, string name)
        {
            a = _a;
            Name = name;
            if (_a > 10)
            {
                ex = multiply; // Присваиваем этой переменной адрес метода
            }
            else
            {
                ex = add;
            }
            ex(a); //Вызываем метод


        } //конструктор класса

        public void hexagon_name()
        {
            Console.WriteLine("Name:" + Name);
        }
        public override void Show() //метод вывода информации об объекте
        {
            Console.WriteLine("Предок:" + (this.GetType().BaseType).ToString());
            Console.WriteLine("Абстрактный класс:" + (this.GetType().BaseType).BaseType.ToString());
            Console.WriteLine("Объект:" + (this.GetType().Name).ToString());
        }
        private static void multiply(int a)
        {
            Console.WriteLine("a*2=" + (a * 2).ToString());
        }
        private static void add(int a)
        {
            Console.WriteLine("a+2=" + (a + 2).ToString());
        }

        ~hexagon()
        {
            Console.WriteLine("Destructor");
        }// деструктор класса
    }
}
