using System;

class Student
{
    static void Main(string[] args)
    {
        string? studentName;
        int studentAge;
        double gpa;
        bool isRegistered;

        Console.Write("Enter your name: ");
        studentName = Console.ReadLine();

        Console.Write("Enter your age: ");
        studentAge = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your gpa: ");
        gpa = Convert.ToDouble(Console.ReadLine());

        Console.Write("Have you registered: ");
        isRegistered = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("Name: " + studentName);
        Console.WriteLine("Age: " + studentAge + "years old");
        Console.WriteLine("GPA: " + gpa);
        Console.WriteLine("isRegistered: " + isRegistered);
        
    }
}