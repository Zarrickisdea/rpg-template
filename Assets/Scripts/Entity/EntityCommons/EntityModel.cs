public class EntityModel
{
    protected EntityController EntityController { get; set; }
    protected float health;
    public EntityModel(EntityController entityController)
    {
        EntityController = entityController;
    }

    public float Health
    {
        get
        {
            return health;
        }
        set
        {
            health += value;
        }
    }
}
