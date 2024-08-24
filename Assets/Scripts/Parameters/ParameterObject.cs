using UnityEngine;

[CreateAssetMenu(fileName = "ParameterObject", menuName = "ParameterObject")]
public class ParameterObject : ScriptableObject
{
    [SerializeField]
    private ParameterUniqueId parameterId;

    [SerializeField]
    private float baseValue;

    private ParameterData parameterData;

    public ParameterObject()
    {
        parameterData = new ParameterData(parameterId, baseValue);
    }

    public ParameterData ParameterData
    {
        get
        {
            return parameterData;
        }
    }
}