using System.Collections.Generic;
using UnityEngine;

public class EntityScriptableObject : ScriptableObject
{
    [SerializeField]
    private EntityView entityObject;

    [SerializeField]
    private List<AttributeData> attributeDataList = new List<AttributeData>();

    public EntityView EntityObject => entityObject;
    public List<AttributeData> AttributeDataList => attributeDataList;
}
