using System;
using System.Collections.Generic;

public interface ILiteEvent<T>
{
    void On(Action<T> handler);
    void Off(Action<T> handler);
}

public class LiteEvent<T> : ILiteEvent<T>
{
    private List<Action<T>> handlers = new List<Action<T>>();

    public void On(Action<T> handler)
    {
        handlers.Add(handler);
    }

    public void Off(Action<T> handler)
    {
        handlers.Remove(handler);
    }

    public void Trigger(T data = default(T))
    {
        foreach (var handler in handlers.ToArray())
        {
            handler(data);
        }
    }
}