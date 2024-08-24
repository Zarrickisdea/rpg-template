using UnityEngine;
using System;
using System.Collections.Generic;

[Serializable]
public class ParameterUniqueId : IUniqueId<ParameterUniqueId>
{
    public ParameterUniqueId(int id): base(id) { }
}

public static class ParameterIdCollection
{
    static ParameterIdCollection()
    {
        GenericStaticStatCollection<ParameterUniqueId>.AddId(new ParameterUniqueId(0), "Health");
        GenericStaticStatCollection<ParameterUniqueId>.AddId(new ParameterUniqueId(1), "Mana");
        Debug.Log("Parameters Loaded");
    }

    public static string GetParameterName(ParameterUniqueId parameterId)
    {
        return GenericStaticStatCollection<ParameterUniqueId>.GetValue(parameterId);
    }

    public static IEnumerable<KeyValuePair<ParameterUniqueId, string>> GetAllIds()
    {
        return GenericStaticStatCollection<ParameterUniqueId>.GetAllIds();
    }

    public static bool HasParameter(ParameterUniqueId parameterId)
    {
        return GenericStaticStatCollection<ParameterUniqueId>.HasId(parameterId);
    }

    public static ParameterUniqueId AddParameter(ParameterUniqueId parameterId, string name)
    {
        return GenericStaticStatCollection<ParameterUniqueId>.AddId(parameterId, name);
    }
}

public class ParameterData : GenericStatType<ParameterUniqueId>
{
    public ParameterData(ParameterUniqueId parameterId, float baseValue) : base(parameterId, baseValue) { }
}
