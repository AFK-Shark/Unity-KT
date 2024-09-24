using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public float jumpForce = 10f;
    [SerializeField] public float rotationSpeed = 5f;
    [SerializeField] public float movementSpeed = 5f;

    public Rigidbody Rb { get; private set; }

    private void Awake()
    {
        Rb = GetComponent<Rigidbody>();
    }
}
