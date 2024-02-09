// See https://aka.ms/new-console-template for more information

using System;

class RoseBlanches
{
    static void Main()
    {
        Console.Write("How much did you receive money ($)? ");
        
        double totalMoney = Convert.ToDouble(Console.ReadLine());
        
        double booksAndSupplies = 0.75 * totalMoney;
        
        double remainingMoney = totalMoney - booksAndSupplies;
        
        int coffees = (int)(remainingMoney / 2);
        
        int flashComputerNumbers = (int)(remainingMoney / 4);
        
        int subwayTickets = (int)(remainingMoney / 3);

        double whiteRoses = remainingMoney - (coffees * 2 + flashComputerNumbers * 4 + subwayTickets * 3);
        Console.WriteLine($"Book and Supplies: {booksAndSupplies:C}");
        Console.WriteLine($"You can then buy:");
        Console.WriteLine($"{coffees} coffees");
        Console.WriteLine($"{flashComputerNumbers} Flash Computer Numbers");
        Console.WriteLine($"{subwayTickets} subway Tickets");
        Console.WriteLine($"and you will have {whiteRoses:C} for the white roses.");
    }
}


//
using System;

class Interval
{
    static void Main()
    {
        Console.Write("Enter a real number: ");
        double x = Convert.ToDouble(Console.ReadLine());

        bool belongsToI = IsInInterval(x);

        if (belongsToI)
        {
            Console.WriteLine($"x belongs to I");
        }
        else
        {
            Console.WriteLine($"x does not belong to I");
        }
    }

    static bool IsInInterval(double x)
    {
        bool condition1 = (x >= 2 && x < 3);
        bool condition2 = (x >= 0 && x <= 1);
        bool condition3 = (x >= -10 && x <= -2);
        bool result = condition1 && condition2 && condition3;

        return result;
    }
}
