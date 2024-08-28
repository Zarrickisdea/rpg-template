using System.Collections.Generic;
using UnityEngine;

public class EntityScriptableObject : ScriptableObject
{
    [SerializeField]
    private EntityView entityObject;

    [SerializeField]
    private List<AttributeObject> attributeObjects;

    [SerializeField]
    private List<ParameterObject> parameterObjects;

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
                // Debug.Log(attributeObject.AttributeData.StatId);
                attributeDataList.Add(attributeObject.AttributeData);
            }
            return attributeDataList;
        }
    }

    public List<ParameterData> ParameterObjects
    {
        get
        {
            List<ParameterData> parameterDataList = new List<ParameterData>();
            foreach (ParameterObject parameterObject in parameterObjects)
            {
                // Debug.Log(parameterObject.ParameterData.StatId);
                parameterDataList.Add(parameterObject.ParameterData);
            }
            return parameterDataList;
        }
    }
}
