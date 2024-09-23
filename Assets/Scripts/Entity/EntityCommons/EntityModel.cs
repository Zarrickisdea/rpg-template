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
    }

    public ParameterCollection GetParameterList()
    {
        return parameterList;
    }
}
