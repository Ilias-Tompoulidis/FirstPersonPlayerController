using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class PlayerController : MonoBehaviour
{
    //Input
    PlayerInput playerInput;
    Vector2 moveVector;
    Vector2 mouseInput;

    //Player Movement
    Rigidbody rb;
    bool isRunning;

    //Camera
    float yaw = 0;
    float pitch = 0;

    [Tooltip("Player Movement")]
    [SerializeField] float normalSpeed;
    [SerializeField] float sprintSpeed;
    [SerializeField] float jumpHeight;

    [Tooltip("Camera")]
    [SerializeField] GameObject mainCam;
    [SerializeField] float mouseSensitivity;
    [SerializeField] float topClamp;
    [SerializeField] float bottomClamp;

    private void Awake()
    {
        playerInput = new PlayerInput();
        playerInput.Default.Enable();
        playerInput.Default.Jump.performed += Jump;
        playerInput.Default.Sprint.performed += EnableSprint;
        playerInput.Default.Sprint.canceled += DisableSprint;

        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moveVector = playerInput.Default.Movement.ReadValue<Vector2>();    
        mouseInput = playerInput.Default.MouseInput.ReadValue<Vector2>();

        CameraLook(mouseInput);
        transform.rotation = Quaternion.Euler(0f, yaw, 0f);
    }
    private void FixedUpdate()
    {
        float speed = isRunning ? sprintSpeed : normalSpeed;
        rb.velocity = transform.right * moveVector.x * speed + transform.forward * moveVector.y * speed + transform.up * rb.velocity.y;
    }

    void Jump(InputAction.CallbackContext context)
    {
        float verticalVelocity = Mathf.Sqrt(2f * 9.81f * jumpHeight);
        rb.velocity = new Vector3(rb.velocity.x, verticalVelocity, rb.velocity.z);
    }

    void EnableSprint(InputAction.CallbackContext context)
    {
        isRunning = true;
    }

    void DisableSprint(InputAction.CallbackContext context)
    {
        isRunning = false;
    }

    void CameraLook(Vector2 camVector)
    {
        yaw += camVector.x * mouseSensitivity;
        pitch += camVector.y * mouseSensitivity;

        yaw = Mathf.Clamp(yaw, float.MinValue, float.MaxValue);
        pitch = Mathf.Clamp(pitch, bottomClamp, topClamp);

        mainCam.transform.localRotation = Quaternion.Euler(-pitch, 0, 0);
    }
}
