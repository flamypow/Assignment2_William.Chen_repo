using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : Singleton<ScoreManager>
{
    private int _score = 0;

    public void Start()
    {
        Debug.Log("Current Score: " + _score);
    }
    public void CoinCollected()
    {
        _score++;
        Debug.Log("Coin Collected, Current Score: " + _score);
    }

}
