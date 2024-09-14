using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputListener : MonoBehaviour
{
    [SerializedField] private Player player;
    private PlayerInvoker playerInvoker;

    private void Awake()
    {
        playerInvoker = new(player);
    }

    void Update()
    {
        ReadJump();
    }

    private void ReadJump()
        if (Input GetKeyDown(KeyCode.Space))
        {
            //
        }
}
