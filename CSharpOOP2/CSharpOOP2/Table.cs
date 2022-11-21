using System;
namespace CSharpOOP2
{
    public class Table
    {
        public string Color;
        public int Height { get; internal set; }
        public string Material;
        public bool IsForKitchen;
        private int Length;
        internal int Width = 60;
        public string State = "new"; //default setting
        public static string Type = "Furniture"; //static field

        public Table(string color, int height, string material, bool isforkitchen ) //constructor with all parameters
        {
            Color = color;
            Height = height;
            Material = material;
            IsForKitchen = isforkitchen;
        }

        public Table() //empty constructor
        {

        }

        public Table(string color, bool isforkitchen) //constructor with 2 parameters
        {
            Color = color;
            IsForKitchen = isforkitchen;
        }



        private double _addShelves;
        public double AddShelves //only write
        {
            set => _addShelves = value;
        }

        private double _priceForShelves;
        public double PriceForShelves //only read
        {
            get;
        }

        public void RoomForTable()
        {
            if (Color.Equals("White") & Material.Equals("Wood"))
                {
                bool IsForKitchen = true;
                Console.WriteLine("The table is for the kitchen");
            }
            else if (Color.Equals("Braun") & Material.Equals("Wood"))
                {
                bool IsForKitchen = false;
                Console.WriteLine("The table is for the living room");
            }
            else
            {
                bool IsForKitchen = false;
                Console.WriteLine("This table is not for house");
            }
            Console.ReadLine();
        }

        public static void TaskForYou() => Console.WriteLine("What room is your table suitable for?"); //static method

    }
}

