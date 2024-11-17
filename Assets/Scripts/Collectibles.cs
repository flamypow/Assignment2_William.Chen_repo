using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Collectibles : MonoBehaviour
{
    public abstract void OnCollected();

    public void OnTriggerEnter(Collider other)
    {
        OnCollected();
        Destroy(this.gameObject);
    }
}
