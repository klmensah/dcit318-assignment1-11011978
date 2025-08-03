using System;

public class GradeCalculator
{
    public static void Run()
    {
        Console.Write("\nEnter your numerical grade (0 - 100): ");
        if (int.TryParse(Console.ReadLine(), out int grade))
        {
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Grade must be between 0 and 100.");
                return;
            }

            if (grade >= 90) Console.WriteLine("Grade: A");
            else if (grade >= 80) Console.WriteLine("Grade: B");
            else if (grade >= 70) Console.WriteLine("Grade: C");
            else if (grade >= 60) Console.WriteLine("Grade: D");
            else Console.WriteLine("Grade: F");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}
