using System;
namespace C__Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 3 & 4: Create three Objects
            Student student1 = new Student("Ahmad", 20, 85);
            Student student2 = new Student("Sara", 21, 92);
            Student student3 = new Student("Omar", 19, 78);

            // Call the Method for each Object
            Console.WriteLine("===== Student Information =====");
            Console.WriteLine();

            student1.DisplayInfo();
            student2.DisplayInfo();
            student3.DisplayInfo();
        }
    }
}
