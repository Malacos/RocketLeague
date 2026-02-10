using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    private Vector2 moveInput;
    private bool jumpInput;

    void Awake()
    {
        playerInput = new PlayerInput();
    }

    void OnEnable()
    {
        playerInput.Enable();
    }

    void OnDisable()
    {
        playerInput.Disable();
    }

    void Update()
    {
        moveInput = playerInput.Gameplay.Move.ReadValue<Vector2>();
        jumpInput = playerInput.Gameplay.Jump.triggered;

        HandleMovement();
        HandleJump();
    }

    private void HandleMovement()
    {
        // Implement movement logic here
    }

    private void HandleJump()
    {
        if (jumpInput)
        {
            // Implement jump logic here
        }
    }
}