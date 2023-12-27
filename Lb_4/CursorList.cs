using System.Diagnostics;

public class CursorList<T> : ICursorList<T>
{
    private List<T> list = new List<T>();
    private int cursor = -1;
    
    public bool IsEmpty => list.Count == 0;

    public int Count => list.Count;

    public bool CanMoveToNext() => !IsEmpty && cursor < list.Count - 1;

    public bool CanMoveToPrevious() => !IsEmpty && cursor > 0;

    public void Append(T value)
    {
        cursor++;
        list.Insert(cursor, value);
    }

    public T Delete()
    {
        if(IsEmpty) throw new Exception("Cannot delete element. No element available.");
        T returnValue = list[cursor];
        list.RemoveAt(cursor);
        cursor--;
        return returnValue;
    }

    public void MoveToNext()
    {
        if (!CanMoveToNext())
        {
            throw new Exception("Cannot move to the next element. No next element available.");
            return;
        }

        cursor++;
    }

    public void MoveToPrevious()
    {
        if (!CanMoveToPrevious())
        {
            throw new Exception("Cannot move to the next element. No previous element available.");
            return;
        }

        cursor--;
    }


    public T GetCurrentElement()
    {
        if (IsEmpty) throw new Exception("No elements available.");

        return list[cursor];
    }
}

