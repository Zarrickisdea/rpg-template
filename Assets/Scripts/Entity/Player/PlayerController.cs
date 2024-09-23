using UnityEngine;

public class PlayerController : EntityController
{
    public PlayerController() : base()
    {

    }

    public override void InitController(EntityView entity, EntityModel entityModel)
    {
        base.InitController(entity, entityModel);

        Debug.Log("Player Controller Initialized");

        Debug.Log(EntityModel);

        Debug.Log(EntityModel.GetParameterList());
    }
}
