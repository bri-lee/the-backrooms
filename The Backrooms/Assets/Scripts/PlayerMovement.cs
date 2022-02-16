using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    public float moveSpeed = 1f;

    public float sprintSpeed;

    public CharacterController controller;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // Move along x axis
        float z = Input.GetAxis("Vertical"); // Move along z axis

        Vector3 movement = transform.right * x + transform.forward * z;

        sprintSpeed = moveSpeed * 5;

        if (Input.GetKey(KeyCode.LeftShift)) controller.Move(movement * sprintSpeed * Time.deltaTime);
        else controller.Move(movement * moveSpeed * Time.deltaTime);
    }
}
