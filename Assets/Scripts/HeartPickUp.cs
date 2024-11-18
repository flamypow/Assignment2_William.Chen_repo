using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartPickUp : Collectibles
{
    [SerializeField] private HeartPickupScriptableObject _heartPickupSO;
    public override void OnCollected()
    {
        IHealthSystem healthSys = PlayerHealthManager.Instance; //edit here if using different one.
        healthSys.PlayerGainHealth(_heartPickupSO.HealAmount);
    }
}
