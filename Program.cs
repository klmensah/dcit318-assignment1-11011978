using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nSelect a program to run:");
            Console.WriteLine("1. Grade Calculator");
            Console.WriteLine("2. Ticket Price Calculator");
            Console.WriteLine("3. Triangle Type Identifier");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice (1-4): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    GradeCalculator.Run();
                    break;
                case "2":
                    TicketPriceCalculator.Run();
                    break;
                case "3":
                    TriangleTypeIdentifier.Run();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
