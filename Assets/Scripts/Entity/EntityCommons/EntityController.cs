using UnityEngine;

public class EntityController : MonoBehaviour
{
    protected EntityModel EntityModel { get; set; }
    protected EntityView EntityView { get; set; }

    public EntityController(EntityModel entityModel, EntityView entityView)
    {
        EntityModel = entityModel;
        EntityView = entityView;
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
