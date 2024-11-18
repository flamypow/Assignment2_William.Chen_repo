using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    [SerializeField] private SpikeStatsScriptableObject _spikeStats;
    private void OnTriggerEnter(Collider other)
    {
        //knock away
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            other.gameObject.GetComponent<PlayerMovement>().StopPlayerMovement(_spikeStats.StunDuration);
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.Normalize(other.transform.position - transform.position)* _spikeStats.Knockback, ForceMode.Impulse);
            PlayerHealthManager.Instance.PlayerLoseHealth(_spikeStats.Damage);
        }

    }
}
