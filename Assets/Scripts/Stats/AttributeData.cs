public class AttributeData
{
    protected float m_Value;
    public AttributeData(float value)
    {
        m_Value = value;
    }

    public float Value
    {
        get
        {
            return m_Value;
        }
        set
        {
            m_Value = value;
        }
    }
}
