using UnityEngine;

[CreateAssetMenu(fileName = "ParameterObject", menuName = "ParameterObject")]
public class ParameterObject : ScriptableObject
{
    [UniqueIdPropertyDrawer(typeof(ParameterUniqueId))]
    [SerializeField]
    private SerializableIUniqueId<ParameterUniqueId> parameterId;

    [SerializeField]
    private float baseValue;

    private ParameterData parameterData;

    public ParameterObject()
    {
        parameterData = new ParameterData(parameterId.ToUniqueId(), baseValue);
    }

    public ParameterData ParameterData
    {
        get
        {
            return parameterData;
        }
    }
}