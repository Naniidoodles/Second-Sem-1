using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController characterController;
    private Vector3 moveDirection;
    public float speed;

    void Awake()
    {
        characterController = gameObject.GetComponent<CharacterController>();
    }

    private void Start()
    {
        
    }

    void Update()
    {
        moveDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            moveDirection.z += 1; // short for moveDirction.z = moveDirection.z + 1;
        }

        if (Input.GetKey(KeyCode.S))
        {
            moveDirection.z -= 1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveDirection.x += 1;
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveDirection.x -= 1;
        }

        moveDirection *= Time.deltaTime * speed;

        characterController.Move(moveDirection);
    }
}
