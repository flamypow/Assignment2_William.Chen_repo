using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : Singleton<PlayerHealthManager>
{
    private int _playerHealth;
    [SerializeField] private int _startingHealth;
    // Start is called before the first frame update
    void Start()
    {
        _playerHealth = _startingHealth;
        Debug.Log("Current Player Health: " + _playerHealth);
    }

    public void PlayerLoseHealth(int amount)
    {
        _playerHealth = _playerHealth - amount;
        Debug.Log("Player Lost Health, Current Player Health: " + _playerHealth);
        if (_playerHealth <= 0)
        {
            Debug.Log("You Died, but only this print happens");
        }
    }

    public void PlayerGainHealth(int amount)
    {
        if (_playerHealth < _startingHealth)
        {
            _playerHealth = _playerHealth + amount;
        }
        Debug.Log("Player Gained Health, Current Player Health: " + _playerHealth);
    }

}
