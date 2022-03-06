using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    public float moveSpeed = 1f;

    [SerializeField]
    public float sprintSpeedModifier = 5;

    public float sprintSpeed;

    CapsuleCollider playerCollider;

    [SerializeField]
    public float originalHeight;

    [SerializeField]
    public float crouchedHeight = 0.5f;

    public float gravity = -9.5f;

    public CharacterController controller;

    void Start()
    {
        playerCollider = GetComponent<CapsuleCollider>();
        originalHeight = playerCollider.height;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // Move along x axis
        float z = Input.GetAxis("Vertical"); // Move along z axis

        Vector3 movement = transform.right * x + transform.forward * z;
       
        sprintSpeed = moveSpeed * sprintSpeedModifier;

        Vector3 totalDelta = Vector3.zero;

        bool crouched = false;

        if (Input.GetKey(KeyCode.LeftShift) && !(Input.GetKey(KeyCode.LeftControl)))
            totalDelta += (movement * sprintSpeed * Time.deltaTime);
        else totalDelta += (movement * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftControl) && !(Input.GetKey(KeyCode.LeftShift)))
        {
            controller.height = crouchedHeight;
            crouched = true;
            // change capsule collider height
        }
        else if (!(Input.GetKey(KeyCode.LeftControl) && crouched == true))
        {
            controller.height = originalHeight;
            // change capsule collider height
        }

        totalDelta += Vector3.up * gravity * Time.deltaTime;
        controller.Move(totalDelta);
    }
}
