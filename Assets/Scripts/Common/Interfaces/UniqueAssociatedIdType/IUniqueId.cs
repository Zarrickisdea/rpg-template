using System;
using UnityEngine;

[Serializable]
public class IUniqueId<T>
{
    [SerializeField]
    public int Id;
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
