using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [field: SerializeField] public float JumpForce { }
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float movementSpeed;

    public Rigidbode Rb { get; private set; }

    private void Awake()
    {
        Rb = GetComponent<Rigitbody>();
        //
    }
}
