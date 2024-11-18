using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PlayerStats", fileName = "PlayerStatsSO")]
public class PlayerStatsScriptableObject : ScriptableObject
{
    [SerializeField] private float _speed;

    [SerializeField] private int _startingHealth;
    public float MoveSpeed { get { return _speed; } }

    public int StartingHealth { get { return _startingHealth; } }
}
