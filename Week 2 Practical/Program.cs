Main();
void Main()
{
    InputOption();
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

void InputOption()
{
    int Choice = PrintMenu();
    switch (Choice)
    {
        case 1:
            Console.WriteLine("Bonjour");
            break;
        case 2:
            Console.WriteLine("Hola");
            break;
        case 3:
            Console.WriteLine("Hallo");
            break;
        case 4:
            Console.WriteLine("Ciao");
            break;
        default:
            Console.WriteLine("Goodbye");
            break;
    }
}

