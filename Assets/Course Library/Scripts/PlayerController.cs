using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.5f;
    public float turnSpeed;
    public InputAction playerControls;
    Vector3 moveDirection = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // shorizontalInput = Input.GetAxis("Horizontal");
        moveDirection = playerControls.ReadValue<Vector3>();

        // Move vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.right * moveDirection.x);
    }

    void onEnable() {
        playerControls.Enable();
    }
    void onDisable() {
        playerControls.Disable();
    }
}
