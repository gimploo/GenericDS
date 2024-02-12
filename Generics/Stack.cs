
public class Stack<T> where T: struct
{
    private List<T> _buffer = new List<T>();

    public Stack() {}

    public void Push(T val = default)
    {
        _buffer.Add(val);
    }

    public T Pop()
    {
        if (IsEmpty()) 
            throw new Exception("Buffer Underflow, stack is empty");

        int lastIndex = _buffer.Count - 1;
        T output = _buffer[lastIndex];
        _buffer.RemoveAt(lastIndex);
        return output;
    }

    public T Peek()
    {
        return _buffer[_buffer.Count - 1];
    }

    public bool IsEmpty() => _buffer.Count == 0;

}