public interface IPlayerInput 
{
    float Horizontal { get; }
    float Vertical { get; }
    void GetInput();
}