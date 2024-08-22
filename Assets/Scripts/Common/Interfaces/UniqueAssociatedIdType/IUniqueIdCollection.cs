using System.Collections.Generic;

public interface IUniqueIdCollection<T> where T : IUniqueId<T>
{
    IEnumerable<KeyValuePair<T, string>> GetAllIds();

    string GetValue(T id);

    bool HasId(T id);

    T AddId(T id, string name);
}