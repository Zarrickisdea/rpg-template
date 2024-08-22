using System.Collections.Generic;

public class AttributeCollection
{
    private readonly List<AttributeData> attributes = new List<AttributeData>();

    public AttributeCollection(List<AttributeData> attributes)
    {
        this.attributes = attributes;
    }

    public AttributeData GetAttribute(AttributeUniqueId attributeId)
    {
        return attributes.Find(a => a.StatId == attributeId);
    }
}
