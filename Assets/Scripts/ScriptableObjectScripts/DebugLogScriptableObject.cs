using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "DebugLogs", fileName = "DebugLogsSO")]
public class DebugLogScriptableObject : ScriptableObject
{

    [SerializeField] private string _healthManagerStartLog;
    [SerializeField] private string _scoreManagerStartLog;
    [SerializeField] private string _gameOverLog;
    [SerializeField] private string _gainHealthLog;
    [SerializeField] private string _loseHealthLog;
    [SerializeField] private string _gainCoinLog;

    public string HealthManagerStart { get { return _healthManagerStartLog; } }
    public string ScoreManagerStart { get { return _scoreManagerStartLog; } }
    public string GameOver { get { return _gameOverLog; } }
    public string GainHealth { get { return _gainHealthLog; } }
    public string LoseHealth { get { return _loseHealthLog; } }
    public string GainCoin { get { return _gainCoinLog; } }
}
