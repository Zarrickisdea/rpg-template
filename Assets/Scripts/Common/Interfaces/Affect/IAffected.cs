public interface IAffected
{
    void ApplyEffect(IAffector affector);
    void RemoveEffect(IAffector affector);
}