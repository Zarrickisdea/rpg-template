using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class AttributeUniqueId : IUniqueId<AttributeUniqueId>
{
    public AttributeUniqueId(int id): base(id) { }
}

public static class AttributeIdCollection
{
    static AttributeIdCollection()
    {
        GenericStaticStatCollection<AttributeUniqueId>.AddId(new AttributeUniqueId(0), "Strength");
        GenericStaticStatCollection<AttributeUniqueId>.AddId(new AttributeUniqueId(1), "Dexterity");
        GenericStaticStatCollection<AttributeUniqueId>.AddId(new AttributeUniqueId(2), "Constitution");
        GenericStaticStatCollection<AttributeUniqueId>.AddId(new AttributeUniqueId(3), "Intelligence");
        GenericStaticStatCollection<AttributeUniqueId>.AddId(new AttributeUniqueId(4), "Wisdom");
        GenericStaticStatCollection<AttributeUniqueId>.AddId(new AttributeUniqueId(5), "Charisma");
    }

    public static string GetAttributeName(AttributeUniqueId attributeId)
    {
        return GenericStaticStatCollection<AttributeUniqueId>.GetValue(attributeId);
    }

    public static IEnumerable<KeyValuePair<AttributeUniqueId, string>> GetAllIds()
    {
        return GenericStaticStatCollection<AttributeUniqueId>.GetAllIds();
    }

    public static bool HasAttribute(AttributeUniqueId attributeId)
    {
        return GenericStaticStatCollection<AttributeUniqueId>.HasId(attributeId);
    }

    public static AttributeUniqueId AddAttribute(AttributeUniqueId attributeId, string name)
    {
        return GenericStaticStatCollection<AttributeUniqueId>.AddId(attributeId, name);
    }
}

public class AttributeData : GenericStatType<AttributeUniqueId>
{
    public AttributeData(AttributeUniqueId statId, float baseValue) : base(statId, baseValue) { }
}