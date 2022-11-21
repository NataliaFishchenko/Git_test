using System;
using System.Xml.Linq;

namespace CSharpOOP3
{
    public class Cylinder : Shape
    {
        private string _name;
        public double Height;
        public double Radius;

        public Cylinder(string name, double height, double radius) : base(name)
        {
            _name = name;
            Height = height;
            Radius = radius;
        }
        public override double Volume()
        {
            return (Math.PI * Radius * Radius * Height);
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Shape {_name} has a volume {Volume()}");
        }
    }
}

