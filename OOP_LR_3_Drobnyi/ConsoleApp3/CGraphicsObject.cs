using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    public abstract class CGraphicsObject
    {
        public int x1 { set; get; } //поля класса + setter&getter
        public int y1 { set; get; }

        public abstract void Show();
    }
}