using System;

class GreenvilleIdol
{
    const decimal ticketPrice = 25.00m;

    static void Main(string[] args)
    {
        while (true)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CalculateRevenue();
                    break;
                case "2":
                    Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
                    return;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("************************************" + "\n*  The stars shine in Greenville.  *" + "\n************************************");
        Console.WriteLine("\nPlease Enter the following number below from the following menu: ");
        Console.WriteLine("\n1. CALCULATE Greenville Revenue Year-Over-Year" + "\n2. Exit");
    }

    static void CalculateRevenue()
    {
        try
        {
            int contestantsThisYear = GetContestantInput("Enter the number of contestants this year: ");
            int contestantsLastYear = GetContestantInput("Enter the number of contestants last year: ");

            decimal expectedRevenue = contestantsThisYear * ticketPrice;
            Console.WriteLine($"Revenue expected this year is ${expectedRevenue}");

           
            if (contestantsThisYear >= 2 * contestantsLastYear)
            {
                Console.WriteLine("The competition is more than twice as big this year!");
            }
            
            else if (contestantsThisYear > contestantsLastYear)
            {
                Console.WriteLine("The competition is bigger than ever!");
            }
           
            else
            {
                Console.WriteLine("A tighter race this year! Come out and cast your vote!");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }

    
    static int GetContestantInput(string prompt)
    {
        int contestants;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out contestants) && contestants >= 0 && contestants <= 30)
            {
                return contestants;
            }
            else
            {
                Console.WriteLine("Please enter a valid number between 0 and 30.");
            }
        }
    }
}
