// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Text;

new Homework_3().Task_3();

class Homework
{
 public void Task_1()
    {
        int a = 5;
        double b = 3.456;
        char c = 'F';
        bool d = true;
        string e = "Hello";

        a = 7;
        b = 4.5678;
        c = 'K';
        d = false;
        e = "Natalia";

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(e);
        Console.ReadLine();
    }

    public void Task_2()
    {
        int a = 6;
        int b = 6;
        object a1 = 7;
        object b1 = 7;

        bool c = a == b;
        bool d = a.Equals(b);

        bool c1 = a1 == b1;
        bool d1 = a1.Equals(b1);

        Console.WriteLine($"Value types are compared using == : {c}");
        Console.WriteLine($"Value types are compared using Equals: {d}");
        Console.WriteLine($"Reference types are compared using == : {c1}");
        Console.WriteLine($"Reference types are compared using Equals: {d1}");
        Console.ReadLine();

    }

    public void Task_3()
    {
        Console.WriteLine("Enter your first name:");
        var firstName = Console.ReadLine();
        Console.WriteLine("Enter your last name:");
        var lastName = Console.ReadLine();
        Console.WriteLine("Enter your age:");
        var age = Console.ReadLine();

        Console.WriteLine($"\"How old are you\", - policemen asked.\n\"{age}\", - {firstName} {lastName} answered.");
        Console.ReadLine();

    }

    public void Task_4()
    {
        Console.WriteLine("Enter your Word 1:");
        string a1 = Console.ReadLine();
        Console.WriteLine("Enter your Word 2:");
        string a2 = Console.ReadLine();
        Console.WriteLine("Enter your Word 3:");
        string a3 = Console.ReadLine();

        string[] latinProverb = new string[] {a1,a2,a3};
        string b = string.Join(" ",latinProverb);

        string c = string.Concat( a1," ", a2," ", a3 );

        Console.WriteLine($"Operation Join: {b}");
        Console.WriteLine($"Operation Concat: {c}");
        Console.ReadLine();

    }

    public void Task_5()
    {
        string text = "Natalia";
        string a = text.Substring(0, text.Length - 5);
        string b = text.Substring(2);

        string[] textParts = new string[] { a, b };
        string c = string.Join(" ",textParts);
        Console.WriteLine(c);
        Console.ReadLine();
    }

    public void Task_6()
    {
        string Text = "I like reading funny stories";
        string Antonym = "sad";

        string newText = Text.Replace("funny", Antonym);
        Console.WriteLine(newText);
        Console.ReadLine();
    }

    public void Task_7()
    {
        Console.WriteLine("Enter your text");
        var text = Console.ReadLine();

        Console.WriteLine(text.ToUpper());
        Console.ReadLine();
    }

    public void Task_8()
    { 
        StringBuilder sb = new StringBuilder("I like ");
        sb.Append("reading ");
        sb.Append("a book ");
        sb.Append("every night.");

        Console.WriteLine(sb);
        Console.ReadLine();

    }
}

class Homework_3
    {
    public void Task_1()
    {
        Console.WriteLine("Enter a number:");
        var numberToString = Console.ReadLine();
        var numberToInt = Convert.ToInt32(numberToString);
        if (numberToInt % 2 == 0 && numberToInt % 5 == 0)
        {
            Console.WriteLine("tutti-frutti");
        }
        else if (numberToInt % 2 == 0)
        {
            Console.WriteLine("tutti");
        }
        else if (numberToInt % 5 == 0) 
        {
            Console.WriteLine("frutti");
        }
        Console.ReadLine();
    }

    public void Task_2()
    {
        Console.WriteLine("Enter a number:");
        var numberToString1 = Console.ReadLine();
        var numberToInt1 = Convert.ToInt32(numberToString1);
        Console.WriteLine("Enter a number that is more than the first one:");
        var numberToString2 = Console.ReadLine();
        var numberToInt2 = Convert.ToInt32(numberToString2);
        if (numberToInt1 > numberToInt2)
        {
            Console.WriteLine($"You didn't fullfit the condition: {numberToInt1} > {numberToInt2}");
            Console.ReadLine();
        }
        for (int numberInInterval = numberToInt1; numberInInterval <= numberToInt2; numberInInterval++)
        {
            if (numberInInterval%2==0 && numberInInterval%5==0)
            {
                Console.WriteLine("tutti-frutti");
            }
            else if (numberInInterval % 2 == 0)
            {
                Console.WriteLine("tutti");
            }
            else if (numberInInterval % 5 == 0)
            {
                Console.WriteLine("frutti");
            }
            else
            {
                Console.WriteLine($"Number {numberInInterval} can't be divided on 2 or 5");
            }
        }
        Console.ReadLine();
    }

    public void Task_3()
    {
        Console.WriteLine("Enter a number 1:");
        var numberToString1 = Console.ReadLine();
        var numberToInt1 = Convert.ToInt32(numberToString1);
        Console.WriteLine("Enter a number 2:");
        var numberToString2 = Console.ReadLine();
        var numberToInt2 = Convert.ToInt32(numberToString2);
        int maxNumber;
        int minNumber;
        if (numberToInt1 == numberToInt2)
        {
            Console.WriteLine($"{numberToInt1} = {numberToInt2}");
        }
        if (numberToInt1 > numberToInt2)
        {
            maxNumber = numberToInt1;
            minNumber = numberToInt2;
        }
        else
        {
            maxNumber = numberToInt2;
            minNumber = numberToInt1;
        }

        while (minNumber <= maxNumber)
        {
            //Console.WriteLine($"{minNumber} < {maxNumber}");
            if (minNumber % 2 == 0 && minNumber % 5 == 0)
            {
                Console.WriteLine("tutti-frutti");
            }
            else if (minNumber % 2 == 0)
            {
                Console.WriteLine("tutti");
            }
            else if (minNumber % 5 == 0)
            {
                Console.WriteLine("frutti");
            }
            else
            {
                Console.WriteLine($"Number {minNumber} can't be divided on 2 or 5");
            }
            minNumber++;
        }
        Console.ReadLine();
    }

}

    
