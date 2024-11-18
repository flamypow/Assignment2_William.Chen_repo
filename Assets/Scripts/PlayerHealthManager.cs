using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : Singleton<PlayerHealthManager>, IHealthSystem
{
    private int _playerHealth;
    [SerializeField] private PlayerStatsScriptableObject _playerStats;

    private IUIHealth _UIManager;
    // Start is called before the first frame update
    void Start()
    {
        _UIManager = DebugDisplayManager.Instance;
        _playerHealth = _playerStats.StartingHealth;
        _UIManager.OnPlayerHealthManagerStart(_playerHealth);
    }

    public void PlayerLoseHealth(int amount)
    {
        _playerHealth = _playerHealth - amount;
        _UIManager.OnLoseHealth(_playerHealth);
        if (_playerHealth <= 0)
        {
            _UIManager.OnGameOver();
        }
    }

    public void PlayerGainHealth(int amount)
    {
        if (_playerHealth < _playerStats.StartingHealth)
        {
            _playerHealth = _playerHealth + amount;
        }
        _UIManager.OnGainHealth(_playerHealth);
    }

}
