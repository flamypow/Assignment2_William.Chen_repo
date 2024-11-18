using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugDisplayManager : Singleton<DebugDisplayManager>, IUIScore, IUIHealth
{
    [SerializeField] private DebugLogScriptableObject debugLog;
    public void OnPlayerHealthManagerStart(int playerHealth)
    {
        Debug.Log(debugLog.HealthManagerStart + playerHealth);
    }

    public void OnScoreManagerStart(int score)
    {
        Debug.Log(debugLog.ScoreManagerStart + score);
    }

    public void OnGameOver()
    {
        Debug.Log(debugLog.GameOver);
    }

    public void OnGainHealth(int amount)
    {
        Debug.Log(debugLog.GainHealth + amount);
    }

    public void OnLoseHealth(int amount)
    {
        Debug.Log(debugLog.LoseHealth + amount);
    }

    public void OnGainCoin(int score)
    {
        Debug.Log(debugLog.GainCoin + score);
    }
}
