using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Generate a random number between 50 and 75
            //Random random = new Random();
            //int secretNumber = random.Next(50, 76);

            //// Variables
            //int guess = 0;
            //int attempts = 0;
            //int points = 0;

            //Console.WriteLine("===== Guessing Game =====");

            //// Keep asking until the user guesses correctly
            //while (guess != secretNumber)
            //{
            //    Console.Write("Guess a number between 50 and 75: ");
            //    guess = Convert.ToInt32(Console.ReadLine());
            //    attempts++;
            //    if (guess < secretNumber)
            //    {
            //        Console.WriteLine("Try a higher number.");
            //    }
            //    else if (guess > secretNumber)
            //    {
            //        Console.WriteLine("Try a lower number.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Congratulations!");
            //    }
            //}

            //// Calculate points based on the number of attempts
            //if (attempts == 1)
            //{
            //    points = 10;
            //}
            //else if (attempts == 2)
            //{
            //    points = 7;
            //}
            //else if (attempts == 3)
            //{
            //    points = 5;
            //}
            //else
            //{
            //    points = 0;
            //}

            //// Display the final result
            //Console.WriteLine();
            //Console.WriteLine("Attempts: " + attempts);
            //Console.WriteLine("Points: " + points);

            ////Part 2 – School System
            //string[] students = { "Ahmad", "Sara", "Omar", "Lina", "Yazan" };
            //int[] grades = { 85, 92, 68, 75, 90 };
            //Console.WriteLine("===== Students Names =====");
            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine(students[i]);
            //}
            //Console.WriteLine();
            //Console.WriteLine("===== Students Grades =====");
            //foreach (int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}

            //Console.Write("Enter student name: ");
            //string searchName = Console.ReadLine();
            //int index = 0;
            //bool found = false;
            //while (index < students.Length)
            //{
            //    if (students[index] == searchName)
            //    {
            //        found = true;
            //        Console.WriteLine("Student Found!");
            //        break;
            //    }
            //    index++;
            //}
            //if (found == false)
            //{
            //    Console.WriteLine("Student Not Found.");
            //}

            //Console.Write("Enter student grade: ");
            //int gradeInput = Convert.ToInt32(Console.ReadLine());
            //if (gradeInput < 0 || gradeInput > 100)
            //{
            //    Console.WriteLine("Invalid grade.");
            //}
            //else if (gradeInput >= 90)
            //{
            //    Console.WriteLine("Excellent");
            //}
            //else if (gradeInput >= 80)
            //{
            //    Console.WriteLine("Very Good");
            //}
            //else if (gradeInput >= 70)
            //{
            //    Console.WriteLine("Good");
            //}
            //else if (gradeInput >= 60)
            //{
            //    Console.WriteLine("Pass");
            //}
            //else
            //{
            //    Console.WriteLine("Fail");
            //}

            int choice;
            do
            {
                Console.WriteLine("===== School System =====");
                Console.WriteLine("1. Display Students");
                Console.WriteLine("2. Search for Student");
                Console.WriteLine("3. Check Student Result");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Display Students");
                        break;

                    case 2:
                        Console.WriteLine("Search for Student");
                        break;

                    case 3:
                        Console.WriteLine("Check Student Result");
                        break;

                    case 4:
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 4);

        }
    }
}
