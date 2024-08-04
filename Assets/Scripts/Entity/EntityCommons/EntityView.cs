using UnityEngine;

public class EntityView : MonoBehaviour, IAcceptor
{
    protected EntityController EntityController { get; set; }

    public EntityView()
    {
    }

    public virtual void UpdateView()
    {

    }

    public void Accept(IVisitor visitor)
    {
        
    }
}
