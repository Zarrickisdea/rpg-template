using System.Collections.Generic;

public static class AttributeIdCollection
{
    public static readonly Dictionary<int, string> AttributeIds = new Dictionary<int, string>()
    {
        { 0, "Strength" },
        { 1, "Dexterity" },
        { 2, "Constitution" }
    };

    public static string GetAttributeName(int attributeId)
    {
        if (AttributeIds.TryGetValue(attributeId, out string name))
        {
            return name;
        }
        else
        {
            return "Invalid Attribute";
        }
    }

    public static void AddAttribute(int attributeId, string name)
    {
        //TODO: ADD ATTRIBUTE FUNCTIONALITY
    }
}

[System.Serializable]
public class AttributeData
{
    public int attributeId;
    public float baseValue;
    protected float modifiedValue;
    protected float currentValue;
    protected string attributeDataName;

    public float GetValue()
    {
        return currentValue;
    }

    public static string GetAttributeName(int attributeId)
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