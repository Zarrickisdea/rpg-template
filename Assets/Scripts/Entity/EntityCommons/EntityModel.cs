using System;
using System.Collections.Generic;
using UnityEngine;

public class EntityModel
{
    protected EntityController EntityController;
    protected AttributeCollection attributeList;
    protected ParameterCollection parameterList;
    public EntityModel(EntityController entityController, AttributeCollection attributes, ParameterCollection parameters)
    {
        EntityController = entityController;
        attributeList = attributes;
        parameterList = parameters;
        // Debug.Log(attributeList.GetStat(new AttributeUniqueId(0)).GetValue());
    }

    public ParameterCollection GetParameterList()
    {
        return parameterList;
    }
}
