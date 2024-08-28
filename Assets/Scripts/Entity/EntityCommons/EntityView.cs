using UnityEngine;

public class EntityView : MonoBehaviour, IAcceptor
{
    protected EntityController EntityController { get; set; }

    public EntityView(EntityController entityController)
    {
        EntityController = entityController;
    }

    public virtual void UpdateView()
    {

    }

    public void Accept(IVisitor visitor)
    {

    }
}
