using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private float _knockback;
    [SerializeField] private float _stunDuration;
    private void OnTriggerEnter(Collider other)
    {
        //knock away
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            other.gameObject.GetComponent<PlayerMovement>().StopPlayerMovement(_stunDuration);
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.Normalize(other.transform.position - transform.position)*_knockback, ForceMode.Impulse);
            PlayerHealthManager.Instance.PlayerLoseHealth(_damage);
        }

    }
}
