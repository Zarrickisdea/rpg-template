using UnityEngine;

[CreateAssetMenu(fileName = "AttributeObject", menuName = "AttributeObject")]
public class AttributeObject : ScriptableObject 
{
    [UniqueIdPropertyDrawer(typeof(AttributeUniqueId))]
    [SerializeField]
    private SerializableIUniqueId<AttributeUniqueId> attributeId;

    [SerializeField]
    private float baseValue;

    private AttributeData attributeData;

    public AttributeObject()
    {
        // attributeData = new AttributeData(attributeId.ToUniqueId(), baseValue);
    }

    public AttributeData AttributeData
    {
        get
        {
            return attributeData;
        }
    }
}