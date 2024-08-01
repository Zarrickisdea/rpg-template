using System.Collections.Generic;

public class EntityModel
{
    protected EntityController EntityController { get; set; }
    protected Dictionary<string, AttributeData> Attributes { get; set; }
    public EntityModel(EntityController entityController)
    {
        EntityController = entityController;
    }

    public virtual void AddAttribute(AttributeData attributeData)
    {
        Attributes.Add(attributeData.AttributeDataName, attributeData);
    }
}
