public interface IAffector
{
    void ApplyEffect(IAffected affected);
    void RemoveEffect(IAffected affected);
}