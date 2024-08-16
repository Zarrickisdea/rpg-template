using System;
using System.Collections.Generic;

public class EntityModel
{
    protected EntityController EntityController { get; set; }
    protected List<AttributeData> attributeList{ get; set; }
    public EntityModel(EntityController entityController, List<AttributeData> attributes)
    {
        EntityController = entityController;
        attributeList = attributes;
    }
}
