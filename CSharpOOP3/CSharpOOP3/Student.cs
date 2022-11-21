using System;
namespace CSharpOOP3
{
    public struct Student
    {
        public string Name;
        public int Age;

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"The student {Name} is {Age} years old");
        }

    }
}

