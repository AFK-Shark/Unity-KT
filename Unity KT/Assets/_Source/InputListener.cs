using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputListener : MonoBehaviour
{
    [SerializeField] private Player player;
    private PlayerInvoker playerInvoker;

    private void Awake()
    {
        playerInvoker = new PlayerInvoker(player);
    }

    void Update()
    {
        ReadJump();
        ReadMovement();
    }

    private void ReadJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerInvoker.InvokeJump();
        }
    }

    private void ReadMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (horizontalInput != 0 || verticalInput != 0)
        {
            playerInvoker.InvokeMove(horizontalInput, verticalInput);
        }
    }
}
