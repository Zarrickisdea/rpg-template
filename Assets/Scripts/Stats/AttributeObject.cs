using UnityEngine;

[CreateAssetMenu(fileName = "AttributeObject", menuName = "AttributeObject")]
public class AttributeObject : ScriptableObject {

    [SerializeField]
    private AttributeUniqueId attributeId;

    [SerializeField]
    private float baseValue;

    private AttributeData attributeData;

    public AttributeObject()
    {
        attributeData = new AttributeData(attributeId, baseValue);
    }

    public AttributeData AttributeData
    {
        get
        {
            return attributeData;
        }
    }
}