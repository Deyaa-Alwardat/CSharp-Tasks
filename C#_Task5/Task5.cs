
using System;


class Person
{
    public string Name;
    public int Age;

    // Protected: accessible inside Person and its derived classes.
    protected string SchoolName;

    // Private: accessible only inside the Person class.
    // It cannot be accessed directly from Main() or derived classes.
    private string _internalCode = "SCH-101";

    public Person(string name, int age, string schoolName)
    {
        Name = name;
        Age = age;
        SchoolName = schoolName;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"school Name: {SchoolName}");
    }
}


class Student :Person
{
    public int Grade;
    public int StudentId;
    public Student(string name, int age, string schoolName,int grade, int studentId)
     : base(name, age, schoolName)
    {
        Grade = grade;
        StudentId = studentId;
    }
    // Display student information
    public void DisplayStudentInfo()
    {
        DisplayInfo();

        Console.WriteLine($"Grade: {Grade}");
        Console.WriteLine($"Student ID: {StudentId}");
        Console.WriteLine($"School Name: {SchoolName}");
    }
}


class Teacher : Person
{
    // Public auto-implemented property
    public string Subject;

    // Constructor
    public Teacher(string name, int age, string schoolName, string subject)
    : base(name, age, schoolName)
    {
        Subject = subject;
    }

    // Display teacher information
    public void DisplayTeacherInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Subject: {Subject}");
    }
}


sealed class SchoolReport
{
    // Public auto-implemented property
    public string ReportTitle;

    // Constructor receives the report title
    public SchoolReport(string reportTitle)
    {
        ReportTitle = reportTitle;
    }

    // Display the report title
    public void DisplayReportTitle()
    {
        Console.WriteLine($"Report Title: {ReportTitle}");
    }
}

// Another class cannot inherit from SchoolReport
// because the sealed keyword prevents inheritance.
