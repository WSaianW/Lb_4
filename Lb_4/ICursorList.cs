

public interface ICursorList<T>
{
    void Append(T value);
    void MoveToNext();
    void MoveToPrevious();
    T GetCurrentElement();
    bool IsEmpty { get; }
    int Count { get; }
}
