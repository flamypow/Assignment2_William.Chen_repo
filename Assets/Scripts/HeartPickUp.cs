using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartPickUp : Collectibles
{
    [SerializeField] private HeartPickupScriptableObject _heartPickupSO;
    public override void OnCollected()
    {
        PlayerHealthManager.Instance.PlayerGainHealth(_heartPickupSO.HealAmount);
    }
}
