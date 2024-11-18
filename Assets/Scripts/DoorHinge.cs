using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHinge : MonoBehaviour
{
    [SerializeField] private Vector3 _openState;
    private bool isOpened;
    public void Open()
    {
        if (!isOpened)
        {
            transform.Rotate(_openState);
            isOpened = true;
        }
    }
}
