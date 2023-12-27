public class CursorList<T> : ICursorList<T>
{
    private T[] array;
    private int cursor;

    public CursorList()
    {
        array = new T[0];
        cursor = -1;
    }
    
    public bool IsEmpty => array.Length == 0;

    public void Append(T value)
    {
        Array.Resize(ref array, array.Length + 1);
        array[array.Length - 1] = value;
        cursor = array.Length - 1;
    }

    public void MoveToNext()
    {
        if (!IsEmpty)
        {
            if (cursor < array.Length - 1)
            {
                cursor++;
                Console.WriteLine($"Moved to the next element (Element {cursor + 1}).");
            }
            else
            {
                Console.WriteLine("Cannot move to the next element. No next element available.");
            }
        }
        else
        {
            Console.WriteLine("Cannot move to the next element. List is empty.");
        }
    }

    public void MoveToPrevious()
    {
        if (!IsEmpty)
        {
            if (cursor > 0)
            {
                cursor--;
                Console.WriteLine($"Moved to the previous element (Element {cursor + 1}).");
            }
            else
            {
                Console.WriteLine("Cannot move to the previous element. No previous element available.");
            }
        }
        else
        {
            Console.WriteLine("Cannot move to the previous element. List is empty.");
        }
    }

    public T GetCurrentElement()
    {
        if (!IsEmpty && cursor >= 0 && cursor < array.Length)
        {
            return array[cursor];
        }
        else
        {
            return default(T);
        }
    }
    
    public int Count => array.Length;
}

