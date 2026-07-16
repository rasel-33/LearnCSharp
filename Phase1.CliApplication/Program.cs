
decimal[] expenses = new decimal[100];
string[] descriptions = new string[100];
int count = 0;

int ShowMenu()
{
    Console.WriteLine("1. Add Expense");
    Console.WriteLine("2. List Expenses");
    Console.WriteLine("3. Show Total & Average");
    Console.WriteLine("4. Exit");
    Console.Write("Select an option: ");
    
    if (int.TryParse(Console.ReadLine(), out int choice))
    {
        return choice;
    }
    
    return 0; // Invalid choice
}

bool runCli = true;
while(runCli)
{
    int choice = ShowMenu();
    
    switch(choice)
    {
        case 1:
            // Capacity check
            if (count == 100)
            {
                Console.WriteLine("Expense list is full. Cannot add more expenses.");
                break;
            }
            Console.Write("Enter expense amount: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal amount))
            {
                Console.Write("Enter expense description: ");
                descriptions[count] = Console.ReadLine() ?? "";
                expenses[count] = amount;
                count++;
            }
            else
            {
                Console.WriteLine("Invalid expense amount. Please try again.");
            }
            break;
            
        case 2:
            if (count == 0)
            {
                Console.WriteLine("No expenses yet");
            }
            else
            {
                Console.WriteLine("Expenses:");
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"{i + 1}. {descriptions[i]} - ${expenses[i]:F2}");
                }
                Console.WriteLine();
            }
            break;
        
        case 3:
            if (count == 0)
            {
                Console.WriteLine("No expenses yet");
            }
            else
            {
                decimal total = 0;
                for (int i = 0; i < count; i++)
                {
                    total += expenses[i];
                }
                decimal average = total / count;
                Console.WriteLine($"Total Expenses: ${total:F2}");
                Console.WriteLine($"Average Expense: ${average:F2}");
            }
            break;

        case 4:
            runCli = false;
            Console.WriteLine("Exiting the application.");
            break;

        default:
            Console.WriteLine("Invalid choice. Please select a valid option.");
            break;
    }
    
}
