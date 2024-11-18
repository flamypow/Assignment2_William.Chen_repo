public interface IUIHealth
{
    public void OnPlayerHealthManagerStart(int playerHealth)
    { }

    public void OnGameOver()
    { }

    public void OnGainHealth(int amount)
    { }

    public void OnLoseHealth(int amount)
    { }

}