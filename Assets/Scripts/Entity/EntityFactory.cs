using UnityEngine;

public class EntityFactory : MonoBehaviour
{
    public EntityController CreateEntity(EntityScriptableObject entity)
    {
        return new EntityController();
    }
}
