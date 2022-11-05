// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using static System.Math;


#region Task_1

Console.WriteLine("Enter the number of potatos:");
var itemNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the price for 1 potato:");
var unitPrice = double.Parse(Console.ReadLine());
Console.WriteLine("Enter your discount:");
var discount = int.Parse(Console.ReadLine());

double sumWithDiscount = new Homework().TotalSum(unitPrice, discount, itemNumber);

Console.WriteLine($"Total: {sumWithDiscount}");
Console.ReadLine();

#endregion

//#region Task_2

//Console.WriteLine("Enter the name of your item №1:");
//var itemName1 = Console.ReadLine();
//Console.WriteLine("Enter the number of items:");
//var itemNumber1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter the price for 1 item:");
//var unitPrice1 = double.Parse(Console.ReadLine());
//Console.WriteLine("Enter the name of your item №2:");
//var itemName2 = Console.ReadLine();
//Console.WriteLine("Enter the number of item №2:");
//var itemNumber2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter the price for one item №2:");
//var unitPrice2 = double.Parse(Console.ReadLine());
//Console.WriteLine("Enter the name of your item №3:");
//var itemName3 = Console.ReadLine();
//Console.WriteLine("Enter the number of item №3:");
//var itemNumber3 = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter the price for one item №3:");
//var unitPrice3 = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter your discount:");
//var discount = int.Parse(Console.ReadLine());

//var sumForItem1 = new Homework().TotalSum(unitPrice1, discount, itemNumber1);
//var sumForItem2 = new Homework().TotalSum(unitPrice2, discount, itemNumber2);
//var sumForItem3 = new Homework().TotalSum(unitPrice3, discount, itemNumber3);

//Console.WriteLine("Items/Numbers/Price/Summ with discount:");
//new Homework().PrintBill(itemName1, unitPrice1, discount, itemNumber1);
//new Homework().PrintBill(itemName2, unitPrice2, discount, itemNumber2);
//new Homework().PrintBill(itemName3, unitPrice3, discount, itemNumber3);

//var sumTotal = sumForItem1 + sumForItem2 + sumForItem3;
//Console.WriteLine($"Total: {sumTotal}");
//Console.ReadLine();

//#endregion

//#region Task_3

//int itemNumber1 = 5;
//Console.WriteLine("Enter the name of your item №1:");
//var itemName1 = Console.ReadLine();
////Console.WriteLine("Enter the number of items:");
////var itemNumber1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter the price for 1 item:");
//var unitPrice1 = double.Parse(Console.ReadLine());
//Console.WriteLine("Enter the name of your item №2:");
//var itemName2 = Console.ReadLine();
////Console.WriteLine("Enter the number of item №2:");
////var itemNumber2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter the price for one item №2:");
//var unitPrice2 = double.Parse(Console.ReadLine());
//Console.WriteLine("Enter the name of your item №3:");
//var itemName3 = Console.ReadLine();
////Console.WriteLine("Enter the number of item №3:");
////var itemNumber3 = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter the price for one item №3:");
//var unitPrice3 = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter your discount:");
//var discount = int.Parse(Console.ReadLine());

//var sumForItem1 = new Homework().TotalSum(unitPrice1, discount, itemNumber1);
//var sumForItem2 = new Homework().TotalSum(unitPrice2, discount);
//var sumForItem3 = new Homework().TotalSum(unitPrice3, discount, 15);


//Console.WriteLine("Items/Numbers/Price/Summ with discount:");
//new Homework().PrintWithoutItemNumber(itemName1, unitPrice1, discount, itemNumber1);
//new Homework().PrintWithoutItemNumber(itemName2, unitPrice2, discount);
//new Homework().PrintWithoutItemNumber(itemName3, unitPrice3, discount, 15);


//var sumTotal = sumForItem1 + sumForItem2 + sumForItem3;
//Console.WriteLine($"Total: {sumTotal}");
//Console.ReadLine();

//#endregion

//#region Task_4

//Console.WriteLine("Enter a side length 1:");
//var side1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter a side length 2:");
//var side2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter a side length 3:");
//var side3 = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter a side length 4:");
//var side4 = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter a side length 5:");
//var side5 = int.Parse(Console.ReadLine());
//var perimeterTriangle = new Homework().Perimeter(side1, side2, side3);
//var perimiterQuadrilateral = new Homework().Perimeter(side1, side2, side3, side4);
//var perimeterPentagon = new Homework().Perimeter(side1, side2, side3, side4, side5);
//Console.WriteLine($"Perimeter of triangle is {perimeterTriangle}");
//Console.WriteLine($"Perimeter of quadrilateral is {perimiterQuadrilateral}");
//Console.WriteLine($"Perimeter of pentagon is {perimeterPentagon}");
//Console.ReadLine();

//#endregion

//#region Task_5

//Console.WriteLine("Enter a side legth of square:");
//var sideSquare = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter a radius:");
//var radiusCircle = double.Parse(Console.ReadLine());
//var areaOfSquare = new Homework().Area(sideSquare);
//double areaOfCircle = new Homework().Area(radiusCircle);
//Console.WriteLine($"Area of square is {areaOfSquare}");
//Console.WriteLine($"Area of circle is {areaOfCircle}");
//Console.ReadLine();

//#endregion

public class Homework
    {
        public double TotalSum(double unitPrice, int discount, int itemNumber = 10)
        {
            var sum = itemNumber * unitPrice;
            var total = sum - sum * discount / 100;
            return total;
        }
        public void PrintBill(string itemName, double unitPrice, int discount, int itemNumber)
        {
            var sum = new Homework().TotalSum(unitPrice, discount, itemNumber);
            Console.WriteLine($"{itemName} {itemNumber} {unitPrice} {sum}");
        }
        public void PrintWithoutItemNumber(string itemName, double unitPrice, int discount, int itemNumber = 10)
        {
            var sum = new Homework().TotalSum(unitPrice, discount, itemNumber);
            Console.WriteLine($"{itemName} {itemNumber} {unitPrice} {sum}");
        }
        public int Perimeter(params int[] sides)
        {
            int sum = 0;
            foreach (int n in sides)
            {
                sum += n;
            }
            return sum;
        }
        public double Area(int number)
        {
            double area = number * number;
            return area;
        }
        public double Area(double number)
        {
            double area = number * number * Math.PI;
            return area;
        }

    }


