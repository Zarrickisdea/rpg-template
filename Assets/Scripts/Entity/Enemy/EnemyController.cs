using UnityEngine;

public class EnemyController : EntityController
{
    public EnemyController() : base()
    {

    }

    public override void InitController(EntityView entity, EntityModel entityModel)
    {
        base.InitController(entity, entityModel);

        Debug.Log("Enemy Controller Initialized.");

        Debug.Log(EntityModel);

        Debug.Log(EntityModel.GetParameterList());
    }
}
