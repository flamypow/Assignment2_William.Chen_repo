using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyToDoor : Collectibles
{
    [SerializeField] private DoorHinge[] _doorsToOpen;
    public override void OnCollected()
    {
        foreach (DoorHinge door in _doorsToOpen)
        {
            door.Open();
        }
    }

}
