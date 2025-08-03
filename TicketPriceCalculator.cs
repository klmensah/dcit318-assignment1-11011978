using System;

public class TicketPriceCalculator
{
    public static void Run()
    {
        Console.Write("\nEnter your age: ");
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            if (age <= 12 || age >= 65)
                Console.WriteLine("Ticket Price: GHC7");
            else
                Console.WriteLine("Ticket Price: GHC10");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}
