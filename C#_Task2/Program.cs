using System;
namespace C__Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1 - Enter Student Information
            Console.Write("Enter student name:");
            string studentName = Console.ReadLine();
            Console.Write("Enter student age: ");
            int studentAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter student grade: ");
            int studentGrade= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter student average: ");
            double studentAverage = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter student gender: ");
            char studentGender = Convert.ToChar(Console.ReadLine());

            // Part 2 - Student Report
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("===== Student Report =====");
            Console.WriteLine("Welcome " + studentName + "!");
            Console.WriteLine("Name: " + studentName);
            Console.WriteLine("Age: " + studentAge);
            Console.WriteLine("Grade: " + studentGrade);
            Console.WriteLine("Average: " + studentAverage);
            Console.WriteLine("Gender: " + studentGender);

            // Part 3 - Student Name
            Console.WriteLine();
            Console.WriteLine("===== Name Information =====");
            Console.WriteLine("Uppercase: " + studentName.ToUpper());
            Console.WriteLine("Lowercase: " + studentName.ToLower());
            Console.WriteLine("First Character: " + studentName[0]);

            // Part 4 - Simple Student Calculation
            double newAverage = studentAverage + 5;
            Console.WriteLine();
            Console.WriteLine("===== Average Calculation =====");
            Console.WriteLine("Original Average: " + studentAverage);
            Console.WriteLine("Bonus Marks: 5");
            Console.WriteLine("New Average: " + newAverage);

            // Part 5 - Student Status
            bool passed = newAverage >= 50;
            bool adult = studentAge >= 18;

            Console.WriteLine();
            Console.WriteLine("===== Student Status =====");
            Console.WriteLine("New Average: " + newAverage);
            Console.WriteLine("Passed: " + passed);
            Console.WriteLine("Adult: " + adult);

            // Final Student Summary
            Console.WriteLine();
            Console.WriteLine("       STUDENT SUMMARY");

            Console.WriteLine("Welcome " + studentName.ToUpper() + "!");
            Console.WriteLine("Name: " + studentName);
            Console.WriteLine("Age: " + studentAge);
            Console.WriteLine("Grade: " + studentGrade);
            Console.WriteLine("Average: " + studentAverage);
            Console.WriteLine("New Average: " + newAverage);
            Console.WriteLine("Gender: " + studentGender);
            Console.WriteLine("Result: " + (passed ? passed : passed));
            Console.WriteLine("Adult: " + adult);

        }
    }
}
