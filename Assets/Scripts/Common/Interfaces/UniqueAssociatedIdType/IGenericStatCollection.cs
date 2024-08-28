using System.Collections.Generic;

public abstract class IGenericStatCollection<TId, TStat>
    where TId : IUniqueId<TId>
    where TStat : class
{
    protected List<TStat> stats = new List<TStat>();

    public IGenericStatCollection(List<TStat> stats)
    {
        this.stats = stats;
    }

    public abstract TStat GetStat(TId id);
}