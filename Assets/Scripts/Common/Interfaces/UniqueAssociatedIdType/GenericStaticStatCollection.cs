using System.Collections.Generic;
public static class GenericStaticStatCollection<T> where T : IUniqueId<T>
{
    private static readonly Dictionary<T, string> GenericStaticStats = new Dictionary<T, string>();

    public static IEnumerable<KeyValuePair<T, string>> GetAllIds()
    {
        return GenericStaticStats;
    }

    public static string GetValue(T id)
    {
        return GenericStaticStats.TryGetValue(id, out var name) ? name : "Invalid Stat Type or Name";
    }

    public static T AddId(T id, string name)
    {
        if (!GenericStaticStats.ContainsKey(id))
        {
            GenericStaticStats.Add(id, name);
        }

        return id;
    }

    public static bool HasId(T id)
    {
        return GenericStaticStats.ContainsKey(id);
    }
}