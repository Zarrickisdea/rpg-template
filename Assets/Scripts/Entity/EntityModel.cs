public class EntityModel
{
    protected EntityController EntityController { get; set; }
    public EntityModel(EntityController entityController)
    {
        EntityController = entityController;
    }
}
