using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SpikesStats", fileName = "SpikesStatsSO")]
public class SpikeStatsScriptableObject : ScriptableObject
{
    [SerializeField] private int _damage;
    [SerializeField] private float _knockback;
    [SerializeField] private float _stunDuration;

    public int Damage { get { return _damage; } }
    public float Knockback { get { return _knockback; } }
    public float StunDuration { get { return _stunDuration; } }
}
