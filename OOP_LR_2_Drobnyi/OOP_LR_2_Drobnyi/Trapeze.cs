using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LR_2
{
    class Trapeze
    {
        public int base1 { set; get; } //поля класса + setter&getter
        public int base2 { set; get; }
        public int height { set; get; }

        public Trapeze(int _base1, int _base2, int _height)
        {
            base1 = _base1; base2 = _base2; height = _height;
        } //конструктор класса
        public int Square()
        {
            return ((base1 + base2) / 2) * height;
        } //метод расчета площади

        ~Trapeze()
        {
            Console.WriteLine("Destructor");
        }// деструктор класса
    }

}