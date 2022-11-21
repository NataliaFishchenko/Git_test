using System;
namespace CSharpOOP3
{
    public class Pyramid : Shape
    {
        private string _name;
        public double Height;
        public double S;

        public Pyramid(string name,double height, double s) : base(name)
        {
            _name = name;
            Height = height;
            S = s;
        }
        public override double Volume()
        {
            return (S * Height / 3);
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Shape {_name} has a volume {Volume()}");
        }

    }
}

