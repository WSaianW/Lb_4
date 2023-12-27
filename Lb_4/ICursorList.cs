public interface ICursorList<T>
{
    void Append(T value);
    T Delete();
    void MoveToNext();
    bool CanMoveToNext();
    void MoveToPrevious();
    bool CanMoveToPrevious();
    T GetCurrentElement();
    bool IsEmpty { get; }
    int Count { get; }
}
