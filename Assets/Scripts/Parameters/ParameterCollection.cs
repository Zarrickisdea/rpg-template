using System.Collections.Generic;

public class ParameterCollection
{
    private readonly List<ParameterData> parameters = new List<ParameterData>();

    public ParameterCollection(List<ParameterData> parameters)
    {
        this.parameters = parameters;
    }

    public ParameterData GetParameter(ParameterUniqueId parameterId)
    {
        return parameters.Find(p => p.StatId == parameterId);
    }
}
