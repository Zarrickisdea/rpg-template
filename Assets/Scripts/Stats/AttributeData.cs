[System.Serializable]
public class AttributeData
{
    public float baseValue;
    public float modifiedValue;
    protected float currentValue;
    public string attributeDataName;
    public AttributeData(float value)
    {
        baseValue = value;
        modifiedValue = 0;
        UpdateCurrentValue(modifiedValue);
    }

    public float GetValue()
    {
        return currentValue;
    }

    public string AttributeDataName
    {
        get { return attributeDataName; }
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
