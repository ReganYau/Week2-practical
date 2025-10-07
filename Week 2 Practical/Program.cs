Main();
void Main()
{
    int choice;
    do
    {
        choice = PrintMenu();
        InputOption(choice);

        if (choice != 0)
        {
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
    while (choice != 0);
    Console.WriteLine("Application closed. Goodbye!");
}
static int PrintMenu()
{
    // declare variable
    int choice = 0;
    bool valid = false;

    while (!valid)
    {
        try
        {
            // Menu
            Console.WriteLine("Please enter a valide option from below:");
            Console.WriteLine("1. Hello in French?");
            Console.WriteLine("2. Hello in Spanish?");
            Console.WriteLine("3. Hello in German?");
            Console.WriteLine("4. Hello in Italian?");
            Console.WriteLine("0. Exit Application");

            // Read user choice menu choice
            Console.Write("Enter your choice (0-4): ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice < 0 || choice > 4)
            {
                Console.WriteLine("Please enter a number between 0 and 4.");
            }
            else
            {
                valid = true;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a number, not text.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: That number is too large or too small.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }

    return choice;
}

void InputOption(int choice)
{
    try
    {
        string translation = GetMessage(choice);
        
        if (translation != null)
        {
            Console.WriteLine($"Your translation is: {translation}");
        }
        else if (choice == 0)
        {
            Console.WriteLine("Exiting application...");
        }
        else
        {
            Console.WriteLine("Invalid option. Please try again.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An unexpected error occured while processing your choice: {ex.Message}");
    }
}

string GetMessage(int option)
{
    switch (option)
    {
        case 1:
            return "Bonjour";
        case 2:
            return "Hola";
        case 3:
            return "Hallo";
        case 4:
            return "Ciao";
        case 0:
            return null;
        default:
            return null;
    }
}

