public interface IUIManager
{
    public void OnPlayerHealthManagerStart(int playerHealth)
    { }

    public void OnScoreManagerStart(int score)
    { }

    public void OnGameOver()
    { }

    public void OnGainHealth(int amount)
    { }

    public void OnLoseHealth(int amount)
    { }

    public void OnGainCoin(int score)
    { }
}