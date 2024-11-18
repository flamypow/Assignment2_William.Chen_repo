using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "HealthPickupStats", fileName = "HealthPickupStatsSO")]
public class HeartPickupScriptableObject : ScriptableObject
{
    [SerializeField] private int _healAmount;

    public int HealAmount { get { return _healAmount; } }
}
