using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private IPlayerInput playerInput;
    [SerializeField] private PlayerStatsScriptableObject _playerStats;
    private bool _canMove;

    private void Start()
    {
        playerInput = new ArrowKeyInput();
        _canMove = true;
    }
    void Update()
    {

        if (_canMove)
        {
            playerInput.GetInput();
            transform.position += new Vector3(playerInput.Horizontal, 0, playerInput.Vertical) * _playerStats.MoveSpeed * Time.deltaTime;
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
