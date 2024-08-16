using System;
using System.Collections.Generic;

public class EntityModel
{
    protected EntityController EntityController { get; set; }
    protected AttributeCollection attributeList{ get; set; }
    public EntityModel(EntityController entityController, AttributeCollection attributes)
    {
        EntityController = entityController;
        attributeList = attributes;
    }
}
