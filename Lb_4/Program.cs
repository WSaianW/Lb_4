class Program
{
    static void Main()
    {
        ICursorList<int> cursorList = new CursorList<int>();
        
        while (true)
        {
            Console.WriteLine($"Current Number of Elements: {cursorList.Count}");
            Console.WriteLine("Interactive Menu:");
            Console.WriteLine("1. Append Element");
            Console.WriteLine("2. Move to Next Element");
            Console.WriteLine("3. Move to Previous Element");
            Console.WriteLine("4. Display Current Element");
            Console.WriteLine("5. Check if List is Empty");
            Console.WriteLine("6. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            try
            {
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the element to append: ");
                        int elementToAppend = int.Parse(Console.ReadLine());
                        cursorList.Append(elementToAppend);
                        Console.WriteLine();
                        Console.WriteLine($"Element {elementToAppend} appended successfully.");
                        break;

                    case "2":
                        if (!cursorList.IsEmpty)
                        {
                            cursorList.MoveToNext();
                            Console.WriteLine();
                            Console.WriteLine("Moved to the next element.");
                        }
                        else
                        {
                            Console.WriteLine("Cannot move to the next element. List is empty.");
                        }
                        break;

                    case "3":
                        if (!cursorList.IsEmpty)
                        {
                            cursorList.MoveToPrevious();
                            Console.WriteLine();
                            Console.WriteLine("Moved to the previous element.");
                        }
                        else
                        {
                            Console.WriteLine("Cannot move to the previous element. List is empty.");
                        }
                        break;

                    case "4":
                        int currentElement = cursorList.GetCurrentElement();
                        Console.WriteLine();
                        Console.WriteLine("Current Element: " + currentElement);
                        break;

                    case "5":
                        bool isEmpty = cursorList.IsEmpty;
                        Console.WriteLine();
                        Console.WriteLine("Is List Empty? " + isEmpty);
                        break;

                    case "6":
                        Console.WriteLine("Exiting the program.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine();
        }
    }
}