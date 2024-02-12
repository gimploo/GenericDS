
public class Queue<T> where T : class
{
    private List<T> _buffer;
    private int _capacity;

    public Queue(uint capacity)
    {
        _buffer = new List<T>((int)capacity);
        _capacity = (int)capacity;
    }

    public void Enqueue(T val = default)
    {
        if (IsFull())
            throw new Exception("Buffer overlow, queue is full");

        _buffer.Add(val);
    }

    public T Dequeue()
    {
        if (IsEmpty()) 
            throw new Exception("Buffer Underflow, queue is empty");

        T val = _buffer[0];
        _buffer.RemoveAt(0);
        return val;
    }

    public bool IsEmpty() => _buffer.Count == 0;
    public bool IsFull() => _buffer.Count == _capacity;

}