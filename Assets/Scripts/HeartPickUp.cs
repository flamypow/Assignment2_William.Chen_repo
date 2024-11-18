using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartPickUp : Collectibles
{
    [SerializeField] private int _healAmount;
    public override void OnCollected()
    {
        PlayerHealthManager.Instance.PlayerGainHealth(_healAmount);
    }
}
