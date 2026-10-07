using System;
namespace SchoolSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = "Sami Ali";
            int studentAge = 20;
            int studentGrade = 12;
            double studentAverage = 85.5;
            char studentGender = 'M';
            bool isStudentActive = true;

            Console.WriteLine(" Student Information");

            Console.WriteLine("Name: " + studentName);
            Console.WriteLine("Age: " + studentAge);
            Console.WriteLine("Grade: " + studentGrade);
            Console.WriteLine("Average: " + studentAverage);
            Console.WriteLine("Gender: " + studentGender);
            Console.WriteLine("Active: " + isStudentActive);


            // =========================
            // Part 2 - Multiple Students
            // =========================

            string[] students = { "Ahmad", "Sara", "Omar", "Lina" };

            Console.WriteLine();
            Console.WriteLine("===== Students =====");

            Console.WriteLine("Student 1: " + students[0]);
            Console.WriteLine("Student 2: " + students[1]);
            Console.WriteLine("Student 3: " + students[2]);
            Console.WriteLine("Student 4: " + students[3]);

            Console.WriteLine("Number of Students: " + students.Length);


            // =========================
            // Part 3 - Access and Change Array Elements
            // =========================

            Console.WriteLine();
            Console.WriteLine("===== Before Change =====");

            Console.WriteLine(students[0]);
            Console.WriteLine(students[1]);
            Console.WriteLine(students[2]);
            Console.WriteLine(students[3]);

            // Change one student
            students[2] = "Khaled";

            Console.WriteLine();
            Console.WriteLine("===== After Change =====");

            Console.WriteLine(students[0]);
            Console.WriteLine(students[1]);
            Console.WriteLine(students[2]);
            Console.WriteLine(students[3]);
        }
    }
}