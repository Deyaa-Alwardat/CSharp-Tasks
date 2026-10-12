using System;

class Student
{
    // Part 1: Properties
    public string Name;
    public int Age;
    public int Grade;

    // Part 5: Constructor
    public Student(string name, int age, int grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }

    // Part 2: Method
    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Grade: " + Grade);
        Console.WriteLine();
    }
}