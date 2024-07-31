using UnityEngine;

public class EntityScriptableObject : ScriptableObject
{
    [SerializeField]
    private GameObject entityObject;

    [SerializeField]
    private AttributeData attributeData;

    public GameObject EntityObject => entityObject;
    public AttributeData AttributeData => attributeData;
}
