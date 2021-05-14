using System;
using System.Collections.Generic;

public class CircularBuffer<T>
{   
    private int capacity { get; }
    private readonly Queue<T> buffer  = new Queue<T>();

    public CircularBuffer(int capacity) => this.capacity = capacity;
    public T Read() => buffer.Count == 0 ? throw new InvalidOperationException("Cannot read from empty buffer") : buffer.Dequeue();
    
    public void Write(T value)
    {
        if(buffer.Count == capacity)
        {
            throw new InvalidOperationException("Cannot write to full buffer");
        }
        buffer.Enqueue(value);
    }

    public void Overwrite(T value)
    {
      
        if (buffer.Count == capacity)
        {
            buffer.Dequeue();
        }

        buffer.Enqueue(value);
    }

    public void Clear() => buffer.Clear();
}