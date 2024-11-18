using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : Collectibles
{
    public override void OnCollected()
    {
        IScoreSystem scoreSys = ScoreManager.Instance; //edit here if using different one.
        scoreSys.CoinCollected();
    }
}
