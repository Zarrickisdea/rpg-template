using System.Collections.Generic;

public class AttributeObject : IAffected
{
    protected List<AttributeData> attributeDatas;
    public AttributeObject(List<AttributeData> attributeDataList)
    {
        attributeDatas = attributeDataList;
    }

    public AttributeData GetAttribute(string name)
    {
        return attributeDatas.Find(x => x.AttributeDataName == name);
    }

    public void ApplyEffect(IAffector affector)
    {
    }

    public void RemoveEffect(IAffector affector)
    {
    }
}
