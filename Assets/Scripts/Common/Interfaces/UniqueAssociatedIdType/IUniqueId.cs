using System;
using UnityEngine;

public class IUniqueId<T>
{
    public int Id { get; }

    public IUniqueId(int id)
    {
        Id = id;
    }

    public override string ToString()
    {
        return Id.ToString();
    }

    public override bool Equals(object obj)
    {
        if (obj is IUniqueId<T> other)
        {
            return Id.Equals(other.Id);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    public static bool operator ==(IUniqueId<T> left, IUniqueId<T> right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(IUniqueId<T> left, IUniqueId<T> right)
    {
        return !(left == right);
    }

    public static bool operator ==(IUniqueId<T> left, T right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(IUniqueId<T> left, T right)
    {
        return !(left == right);
    }
}

[Serializable]
public class SerializableIUniqueId<T> where T : IUniqueId<T>
{
    [SerializeField]
    private int Id;

    public SerializableIUniqueId(int id)
    {
        Id = id;
    }

    public T ToUniqueId()
    {
        return (T)Activator.CreateInstance(typeof(T), Id);
    }
}

public class UniqueIdPropertyDrawer : PropertyAttribute
{
    public Type IdType { get;}

    public UniqueIdPropertyDrawer (Type idType)
    {
        IdType = idType;
    }
}
