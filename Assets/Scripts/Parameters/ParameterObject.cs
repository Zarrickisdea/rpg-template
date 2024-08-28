using UnityEngine;

[CreateAssetMenu(fileName = "ParameterObject", menuName = "ParameterObject")]
public class ParameterObject : ScriptableObject
{
    [SerializeField]
    private ParameterUniqueId parameterId;

    [SerializeField]
    private float baseValue;

    public ParameterData ParameterData
    {
        get
        {
            return new ParameterData(parameterId, baseValue);
        }
    }
}