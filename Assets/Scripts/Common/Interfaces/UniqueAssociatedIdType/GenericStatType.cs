public class GenericStatType<T> where T : IUniqueId<T>
{
    protected T statId;

    protected float baseValue;
    protected float modifiedValue;
    protected float currentValue;

    public T StatId => statId;

    public GenericStatType(T statId, float baseValue)
    {
        this.statId = statId;
        this.baseValue = baseValue;
        modifiedValue = 0;
        currentValue = baseValue;
    }

    public float GetValue()
    {
        return currentValue;
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

    public void ResetValue()
    {
        currentValue = baseValue;
        modifiedValue = 0;
    }
}