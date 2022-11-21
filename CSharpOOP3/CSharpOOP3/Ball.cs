using System;

namespace CSharpOOP3
{
    public class Ball : Shape
    {
        private string _name;
        public double Radius;

        public Ball(string name,double radius) : base (name)
        {
            _name = name;
            Radius = radius;
        }
        public override double Volume()
        { 
            return (4 / 3 * Math.PI * Radius * Radius);
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Shape {_name} has a volume {Volume()}");
        }
    }
}

