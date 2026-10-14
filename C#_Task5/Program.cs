
using System;

class Program
{
    static void Main()
    {
        // Part 1: Create a Person object
        Person person1 = new Person(
            "Khaled", 40, "Al Amal School"
        );

        Console.WriteLine("=== Person Information ===");
        person1.DisplayInfo();
        Console.WriteLine("");
        // Part 2: Create two Student objects
        Student student1 = new Student(
            "Nada", 18, "Al Amal School", 12, 101
        );

        Student student2 = new Student(
            "Omar", 17, "Al Amal School", 11, 102
        );
        Console.WriteLine("");
        Console.WriteLine("\n=== Student 1 ===");
        student1.DisplayInfo();

        // Display additional student information
        student1.DisplayStudentInfo();
        Console.WriteLine("");
        Console.WriteLine("\n=== Student 2 ===");
        student2.DisplayStudentInfo();

        // Part 3: Create a Teacher object
        Teacher teacher1 = new Teacher(
            "Ahmad", 35, "Al Amal School", "Mathematics"
        );
        Console.WriteLine("");
        Console.WriteLine("\n=== Teacher Information ===");
        teacher1.DisplayTeacherInfo();

        // Part 5: Create a SchoolReport object
        SchoolReport report = new SchoolReport(
            "Annual School Report"
        );
        Console.WriteLine("");
        Console.WriteLine("\n=== School Report ===");
        report.DisplayReportTitle();

 
    }
}
