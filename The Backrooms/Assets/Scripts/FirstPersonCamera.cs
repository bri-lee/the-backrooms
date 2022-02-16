using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    float xRotation;
    float mouseSens = 90f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Mouse input
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSens;

        // Rotate Camera up and down
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localEulerAngles = new Vector3(xRotation, 0f, 0f);
    }
}
