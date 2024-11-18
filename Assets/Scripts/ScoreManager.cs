using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : Singleton<ScoreManager>
{
    private int _score = 0;

    private IUIManager _UIManager;

    public void Start()
    {
        _UIManager = DebugDisplayManager.Instance;
        _UIManager.OnScoreManagerStart(_score);

    }
    public void CoinCollected()
    {
        _score++;
        _UIManager.OnGainCoin(_score);
    }

}
