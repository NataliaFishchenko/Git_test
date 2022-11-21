using System;

namespace CSharpOOP3
{
    public abstract class Shape
    {
        private string _name;

        public Shape (string Name)
        {
            _name = Name;
        }
        public abstract double Volume();

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Shape is {_name}");
        }
    }
}

