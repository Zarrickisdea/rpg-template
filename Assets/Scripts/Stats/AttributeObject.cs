public class AttributeObject : IAffected
{
    protected AttributeData AttributeData { get; set; }
    public AttributeObject(AttributeData attributeData)
    {
        AttributeData = attributeData;
    }

    public void ApplyEffect(IAffector affector)
    {
    }

    public void RemoveEffect(IAffector affector)
    {
    }
}
