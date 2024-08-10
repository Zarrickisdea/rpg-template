using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public record AttributeUniqueId
{
    [SerializeField]
    private int attributeId;
    public int AttributeId => attributeId;
    public AttributeUniqueId(int attributeId)
    {
        if (attributeId < 0)
        {
            throw new System.ArgumentException("AttributeId cannot be negative");
        }

        this.attributeId = attributeId;
    }
}

public static class AttributeIdCollection
{
    private static readonly Dictionary<AttributeUniqueId, string> AttributeIds = new Dictionary<AttributeUniqueId, string>
    {
        { new AttributeUniqueId(0), "Strength" },
        { new AttributeUniqueId(1), "Agility" },
        { new AttributeUniqueId(2), "Constitution" }
    };

    public static string GetAttributeName(AttributeUniqueId attributeId)
    {
        return AttributeIds.TryGetValue(attributeId, out var name) ? name : "Invalid Attribute";
    }

    public static bool HasAttribute(AttributeUniqueId attributeId)
    {
        return AttributeIds.ContainsKey(attributeId);
    }

    public static IEnumerable<KeyValuePair<AttributeUniqueId, string>> GetAllAttributes()
    {
        return AttributeIds;
    }
}

public class AttributeData
{
    protected AttributeUniqueId attributeId;
    protected float baseValue;
    protected float modifiedValue;
    protected float currentValue;

    public AttributeData(AttributeUniqueId attributeId, float baseValue)
    {
        if (!AttributeIdCollection.HasAttribute(attributeId))
        {
            throw new System.ArgumentException("Invalid attribute id");
        }
        this.attributeId = attributeId;
        this.baseValue = baseValue;
        modifiedValue = 0;
        currentValue = baseValue;
    }

    public float GetValue()
    {
        return currentValue;
    }

    public static string GetAttributeName(AttributeUniqueId attributeId)
    {
        return AttributeIdCollection.GetAttributeName(attributeId);
    }

    public void ModifyValue(float value)
    {
        modifiedValue += value;
        UpdateCurrentValue(modifiedValue);
    }

    private void UpdateCurrentValue(float modifiedValue)
    {
        currentValue = baseValue + modifiedValue;
    }
}