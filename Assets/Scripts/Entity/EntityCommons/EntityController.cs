using UnityEngine;

public class EntityController
{
    protected EntityModel EntityModel { get; set; }
    protected EntityView EntityView { get; set; }

    public EntityController()
    {
    }

    public virtual void InitController()
    {
        
    }

    public virtual void TakeDamage(float damage)
    {
        EntityView.UpdateView();
    }

    public virtual void DealDamage(float damage)
    {
        EntityView.UpdateView();
    }
}
