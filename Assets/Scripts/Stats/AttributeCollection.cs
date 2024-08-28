using System.Collections.Generic;

public class AttributeCollection : IGenericStatCollection<AttributeUniqueId, AttributeData>
{
    public AttributeCollection(List<AttributeData> stats) : base(stats) { }

    public override AttributeData GetStat(AttributeUniqueId id)
    {
        return stats.Find(stat => stat.StatId == id);
    }
}
