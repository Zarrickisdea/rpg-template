using System.Collections.Generic;
using UnityEngine;

public class EntityScriptableObject : ScriptableObject
{
    [SerializeField]
    private EntityView entityObject;

    [SerializeField]
    private AttributeObject attributeObject;

    public EntityView EntityObject
    {
        get { return entityObject; }
    }

    public AttributeObject AttributeObject
    {
        get { return attributeObject; }
    }
}
