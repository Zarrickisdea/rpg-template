using UnityEngine;

public class EntityController
{
    public EntityModel EntityModel;
    public EntityView EntityView;

    public EntityController()
    {
    }

    public virtual void InitController(EntityView entity, EntityModel entityModel)
    {
        EntityModel = entityModel;
        EntityView = entity;

        Debug.Log("Entity Controller Initialized");
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
