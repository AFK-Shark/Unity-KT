using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerinvoker : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private Player player;

    public Playerinvoker(Player player)
    {
        playerMovement = new();
        this.player = player;
    }

    void InvokeJump()
    {
        playerMovement.Jump(player.JumpForce, player.Rb);
    }
}
