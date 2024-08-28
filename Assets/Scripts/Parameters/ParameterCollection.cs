using System.Collections.Generic;

public class ParameterCollection : IGenericStatCollection<ParameterUniqueId, ParameterData>
{
    public ParameterCollection(List<ParameterData> stats) : base(stats) { }

    public override ParameterData GetStat(ParameterUniqueId id)
    {
        return stats.Find(stat => stat.StatId == id);
    }
}