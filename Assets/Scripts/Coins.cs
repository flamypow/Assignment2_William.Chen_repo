using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : Collectibles
{
    public override void OnCollected()
    {
        ScoreManager.Instance.CoinCollected();
    }
}
