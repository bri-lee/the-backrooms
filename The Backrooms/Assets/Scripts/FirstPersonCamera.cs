using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    float xRotation;
    float mouseSens = 90f;
    public Transform player;
    
    // Start is called before the first frame update
    void Start()
    {
        // Hide and lock cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Mouse input
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSens;
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSens;

        // Rotate Camera up and down
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localEulerAngles = new Vector3(xRotation, 0f, 0f);

        // Rotate Camera left and right
        player.Rotate(Vector3.up * mouseX);
    }
}
