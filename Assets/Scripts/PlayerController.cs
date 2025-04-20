using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private variables
    private float speed = 5.0f; // Speed of the vehicle
    private float turnSpeed; // Speed of the vehicle's rotation
    private float horizontalInput; // Input for horizontal movement
    private float forwardInput; // Input for forward movement

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); // Get the horizontal input (A/D or Left/Right arrow keys)
        forwardInput = Input.GetAxis("Vertical"); // Get the vertical input (W/S or Up/Down arrow keys)

        //We'll move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //We'll turn the vehicle
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
