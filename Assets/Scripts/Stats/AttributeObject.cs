using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AttributeObject", menuName = "AttributeObject", order = 0)]
public class AttributeObject : ScriptableObject {
    [SerializeField]
    private int attributeArchetypeId;

    [SerializeField]
    private List<AttributeData> attributeDataList;
}