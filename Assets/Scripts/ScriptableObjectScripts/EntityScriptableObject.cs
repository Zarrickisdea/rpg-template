using System.Collections.Generic;
using UnityEngine;

public class EntityScriptableObject : ScriptableObject
{
    [SerializeField]
    private EntityView entityObject;

    [SerializeField]
    private List<AttributeObject> attributeObjects;

    public EntityView EntityObject
    {
        get { return entityObject; }
    }

    public List<AttributeData> AttributeObjects
    {
        get
        {
            List<AttributeData> attributeDataList = new List<AttributeData>();
            foreach (AttributeObject attributeObject in attributeObjects)
            {
                attributeDataList.Add(attributeObject.AttributeData);
            }
            return attributeDataList;
        }
    }
}
