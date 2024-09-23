using UnityEngine;

public abstract class EntityFactory<TScript> where TScript : EntityScriptableObject
{
    public EntityController CreateEntity(TScript entityScriptableObject)
    {
        EntityView entityView = entityScriptableObject.EntityObject as EntityView;
        if (entityView != null)
        {
            EntityController entityController = CreateEntityController(entityScriptableObject);
            var attributeList = new AttributeCollection(entityScriptableObject.AttributeObjects);
            var parameterList = new ParameterCollection(entityScriptableObject.ParameterObjects);
            EntityModel entityModel = CreateEntityModel(entityController, attributeList, parameterList);
            var entityGameObject = Object.Instantiate(entityView);
            entityController.InitController(entityGameObject, entityModel);
            return entityController;
        }
        return null;
    }

    protected abstract EntityController CreateEntityController(TScript entityScriptableObject);
    protected abstract EntityModel CreateEntityModel(EntityController entityController, AttributeCollection attributeList, ParameterCollection parameterList);
}

public class PlayerFactory : EntityFactory<PlayerScriptableObject>
{
    protected override EntityController CreateEntityController(PlayerScriptableObject entityScriptableObject)
    {
        return new PlayerController();
    }

    protected override EntityModel CreateEntityModel(EntityController entityController, AttributeCollection attributeList, ParameterCollection parameterList)
    {
        return new PlayerModel(entityController as PlayerController, attributeList, parameterList);
    }
}

public class EnemyFactory : EntityFactory<EnemyScriptableObject>
{
    protected override EntityController CreateEntityController(EnemyScriptableObject entityScriptableObject)
    {
        return new EnemyController();
    }

    protected override EntityModel CreateEntityModel(EntityController entityController, AttributeCollection attributeList, ParameterCollection parameterList)
    {
        return new EnemyModel(entityController as EnemyController, attributeList, parameterList);
    }
}