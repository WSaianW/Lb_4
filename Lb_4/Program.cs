using static System.Console;

class Program
{
    static void PrintAllCommands()
    {
        ForegroundColor = ConsoleColor.Green;
        WriteLine("Interactive Menu:");
        WriteLine("Choises - will print list of all available choises");
        WriteLine("Append {Int} - will add new element of int type");
        WriteLine("Delete - will delete current element");
        WriteLine("CurrentElement - will return element on cursor position");
        WriteLine("Count - will return elements count in list");
        WriteLine("MoveToNext - will move cursor to the next element");
        WriteLine("MoveToPrevious - will move cursor to the previous element");
        WriteLine("IsEmpty - will retur if list is empty");
        WriteLine("Exit - will finish program");
        ForegroundColor = ConsoleColor.White;
    }

    static void Main()
    {
        CursorList<int> cursorList = new CursorList<int>();
        
        PrintAllCommands();
        while (true)
        {
            Write("Enter your choice: ");
            string[] choise = ReadLine().Split();

            try
            {
                switch (choise[0])
                {
                    case "Choises":
                        PrintAllCommands();
                        break;
                    case "Append":

                        if (int.TryParse(choise[1], out int result))
                        {
                            cursorList.Append(result);
                            WriteLine($"Element {result} appended successfully.");
                        }
                        else
                        {
                            WriteLine("Can`t add invalid element");
                        }
                        break;

                    case "Delete":
                        WriteLine($"Deleted element: {cursorList.Delete()}.");
                        break;

                    case "Count":
                        WriteLine($"Elements in list: {cursorList.Count}.");
                        break;

                    case "MoveToNext":
                        cursorList.MoveToNext();
                        WriteLine("Moved to the next element.");
                        break;

                    case "MoveToPrevious":
                        cursorList.MoveToPrevious();
                        WriteLine("Moved to the previous element.");
                        break;

                    case "CurrentElement":
                        WriteLine($"Current Element: {cursorList.GetCurrentElement()}");
                        break;

                    case "IsEmpty":
                        WriteLine($"Is List Empty? {cursorList.IsEmpty}");
                        break;

                    case "Exit":
                        WriteLine("Exiting the program.");
                        return;

                    default:
                        WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
            catch (Exception ex)
            {
                WriteLine($"Error: {ex.Message}");
            }

            WriteLine();
        }
    }
}