using UnityEngine;

[CreateAssetMenu(fileName = "AttributeObject", menuName = "AttributeObject")]
public class AttributeObject : ScriptableObject
{
    [SerializeField]
    private AttributeUniqueId attributeId;

    [SerializeField]
    private float baseValue;

    public AttributeData AttributeData
    {
        get
        {
            return new AttributeData(attributeId, baseValue);
        }
    }
}