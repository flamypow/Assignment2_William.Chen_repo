using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyToDoor : Collectibles
{
    [SerializeField] private DoorHinge[] _doorsToOpen;
    public override void OnCollected()
    {
        Debug.Log("Collected a Key, coorsponding door is opened");
        foreach (DoorHinge door in _doorsToOpen)
        {
            door.Open();
        }
    }

}
