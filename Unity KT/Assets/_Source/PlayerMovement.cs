using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement
{
    public void Jump(float jumpForce, Rigidbody rb)
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    public void Move(float horizontalInput, float verticalInput, float movementSpeed, Rigidbody rb)
    {
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);
        rb.velocity = movement * movementSpeed;
    }
}
