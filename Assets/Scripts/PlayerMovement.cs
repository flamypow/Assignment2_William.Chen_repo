using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float _speed;
    private bool _canMove;

    private void Start()
    {
        _canMove = true;
    }
    void Update()
    {
        if (_canMove)
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            transform.position += new Vector3(horizontal, 0, vertical) * _speed * Time.deltaTime;
        }
    }

    IEnumerator StopMoving(float duration)
    {
        _canMove = false;
        yield return new WaitForSeconds(duration);
        _canMove = true;
    }

    public void StopPlayerMovement(float duration)
    {
        StartCoroutine(StopMoving(duration));
    }
}
