// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Text;

new Homework().Task_8();

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
        var firstName = "Tom";
        var lastName = "Benenson";
        var age = "23";

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
        string a = text.Substring(2);
        string b = a.Substring(3);

        string[] textParts = new string[] { a, b };
        string c = string.Join(" ", textParts);
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

