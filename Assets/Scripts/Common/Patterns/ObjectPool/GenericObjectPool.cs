using System.Collections.Generic;

public class GenericObjectPool<T> where T : class
{
    protected Stack<T> m_Stack = new Stack<T>();
    public virtual T GetObject()
    {
        if (m_Stack.Count > 0)
            return m_Stack.Pop();
        else
            return null;
    }

    public virtual void ReturnObject(T obj)
    {
        m_Stack.Push(obj);
    }

    public virtual void Clear()
    {
        m_Stack.Clear();
    }

    public virtual int Count
    {
        get
        {
            return m_Stack.Count;
        }
    }

    public virtual void Init()
    {
        Clear();
    }
}
