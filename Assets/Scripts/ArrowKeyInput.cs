using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowKeyInput : IPlayerInput
{
    public float Horizontal { get; private set; }
    public float Vertical { get; private set; }


    public void GetInput()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
    }

}
