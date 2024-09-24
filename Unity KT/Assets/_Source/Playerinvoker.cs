using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInvoker : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private Player player;

    public PlayerInvoker(Player player)
    {
        playerMovement = new PlayerMovement();
        this.player = player;
    }

    public void InvokeJump()
    {
        playerMovement.Jump(player.jumpForce, player.Rb);
    }

    public void InvokeMove(float horizontalInput, float verticalInput)
    {
        playerMovement.Move(horizontalInput, verticalInput, player.movementSpeed, player.Rb);
    }
}
