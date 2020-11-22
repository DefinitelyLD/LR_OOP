using System;

namespace LR_5_Drobnyi
{
    interface ITree
    {
        string Type
        {
            get; set;
        }
        void Grow();
        void Tree();
    }
    interface IGnome
    {
        string Name
        {
            get; set;
        }
        void Stay();
        void Gnome();
    }


    class child : ITree, IGnome
    {
        public string Type { get; set; }
        public child(string type)
        {
            Type = type;
        }
        public string Name { get; set; }
        public child(string type , string name)
        {
            Type = type;
            Name = name;
        }
        public void Grow()
        {
            Console.WriteLine("Grow in Tree");
        }
        public void Tree()
        {
            Console.WriteLine(Type);
        }
        public void Stay()
        {
            Console.WriteLine("Stay in Gnome");
        }
        public void Gnome()
        {
            Console.WriteLine(Name);
        }

    }
   
    class Program
    {
        static void Main(string[] args)
        {
            child new_child = new child("Oak", "Bob");
            new_child.Grow();
            new_child.Tree();
            new_child.Stay();
            new_child.Gnome();
            Console.ReadLine();

        }

    }
}
