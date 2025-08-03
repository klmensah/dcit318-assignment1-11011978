using System;

public class TriangleTypeIdentifier
{
    public static void Run()
    {
        Console.WriteLine("\nEnter the lengths of the three sides of the triangle:");

        Console.Write("Side 1: ");
        bool valid1 = double.TryParse(Console.ReadLine(), out double side1);

        Console.Write("Side 2: ");
        bool valid2 = double.TryParse(Console.ReadLine(), out double side2);

        Console.Write("Side 3: ");
        bool valid3 = double.TryParse(Console.ReadLine(), out double side3);

        if (!valid1 || !valid2 || !valid3 || side1 <= 0 || side2 <= 0 || side3 <= 0)
        {
            Console.WriteLine("Invalid input. All sides must be positive numbers.");
            return;
        }

        // Check triangle inequality
        if (side1 + side2 <= side3 || side2 + side3 <= side1 || side1 + side3 <= side2)
        {
            Console.WriteLine("The lengths do not form a valid triangle.");
            return;
        }

        if (side1 == side2 && side2 == side3)
            Console.WriteLine("Triangle Type: Equilateral");
        else if (side1 == side2 || side2 == side3 || side1 == side3)
            Console.WriteLine("Triangle Type: Isosceles");
        else
            Console.WriteLine("Triangle Type: Scalene");
    }
}
