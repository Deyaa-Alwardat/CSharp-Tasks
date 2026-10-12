using System;
using System.Collections.Generic;

namespace CSharpTask3
{
    internal class Program
    {
    
        static string[] students =
        {
            "Ahmad", "Sara", "Omar", "Lina", "Yazan"
        };

        static int[] grades = { 85, 92, 68, 75, 90 };

        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\n===== C# Task 3 =====");
                Console.WriteLine("1. Guessing Game");
                Console.WriteLine("2. School System");
                Console.WriteLine("3. Exit");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        GuessingGame();
                        break;

                    case 2:
                        SchoolSystemMenu();
                        break;

                    case 3:
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 3);
        }

        // ==============================
        // Part 1: Guessing Game
        // ==============================
        static void GuessingGame()
        {
            Random random = new Random();
            int secretNumber = random.Next(50, 76);

            int guess = 0;
            int attempts = 0;
            int points;

            Console.WriteLine("\n===== Guessing Game =====");

            while (guess != secretNumber)
            {
                Console.Write("Guess a number between 50 and 75: ");
                guess = Convert.ToInt32(Console.ReadLine());

                attempts++;

                if (guess < secretNumber)
                {
                    Console.WriteLine("Try a higher number.");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Try a lower number.");
                }
                else
                {
                    Console.WriteLine("Congratulations!");
                }
            }

            if (attempts == 1)
            {
                points = 10;
            }
            else if (attempts == 2)
            {
                points = 7;
            }
            else if (attempts == 3)
            {
                points = 5;
            }
            else
            {
                points = 0;
            }

            Console.WriteLine("Attempts: " + attempts);
            Console.WriteLine("Points: " + points);
        }

        // ==============================
        // Part 2: School System Menu
        // ==============================
        static void SchoolSystemMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n===== School System =====");
                Console.WriteLine("1. Display Students");
                Console.WriteLine("2. Search for Student");
                Console.WriteLine("3. Check Student Result");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayStudents();
                        break;

                    case 2:
                        SearchStudent();
                        break;

                    case 3:
                        CheckStudentResult();
                        break;

                    case 4:
                        Console.WriteLine("Leaving School System...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

            } while (choice != 4);
        }

        // Display student names using for
        // Display grades using foreach
        static void DisplayStudents()
        {
            Console.WriteLine("\n===== Students =====");

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            Console.WriteLine("\n===== Grades =====");

            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }
        }

        // Search for a student using while and break
        static void SearchStudent()
        {
            Console.Write("Enter student name: ");
            string searchName = Console.ReadLine();

            int index = 0;
            bool found = false;

            while (index < students.Length)
            {
                if (students[index].Equals(
                    searchName,
                    StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                    Console.WriteLine("Student Found!");
                    break;
                }

                index++;
            }

            if (found == false)
            {
                Console.WriteLine("Student Not Found.");
            }
        }

        // Check student grade using if / else
        static void CheckStudentResult()
        {
            Console.Write("Enter student grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid grade.");
            }
            else if (grade >= 90)
            {
                Console.WriteLine("Excellent");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Very Good");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Good");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }

    }
}


