using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : Singleton<PlayerHealthManager>
{
    private int _playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Current Player Health: " + _playerHealth);
    }

    public void PlayerLoseHealth(int amount)
    {
        _playerHealth = _playerHealth - amount;
        Debug.Log("Player Lost Health, Current Player Health: " + _playerHealth);
    }

    public void PlayerGainHealth(int amount)
    {
        _playerHealth = _playerHealth + amount;
        Debug.Log("Player Gained Health, Current Player Health: " + _playerHealth);
    }

}
