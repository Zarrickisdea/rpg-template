using UnityEngine;

public class EntityView : MonoBehaviour
{
    protected EntityController EntityController { get; set; }

    public EntityView(EntityController entityController)
    {
        EntityController = entityController;
    }
}
