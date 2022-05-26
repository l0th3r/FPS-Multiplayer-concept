using System;
using UnityEngine;

public class ClientInputCatcher : MonoBehaviour
{
    private PlayerInput input;

    // Event to stream inputs
    public Action<Vector2> OnMovement;
    public Action<Vector2> OnLook;

    private void Awake()
    {
        input = new PlayerInput();

        input.ControllingPawn.movement.performed += OnMovementInput;
        input.ControllingPawn.movement.canceled += OnMovementInput;

        input.ControllingPawn.looking.performed += OnLookingInput;
        input.ControllingPawn.looking.canceled += OnLookingInput;
    }

    private void OnLookingInput(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnLook?.Invoke(obj.ReadValue<Vector2>());
    }

    private void OnMovementInput(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnMovement?.Invoke(obj.ReadValue<Vector2>());
    }


    public void OnEnable()
    {
        input.ControllingPawn.Enable();
    }

    public void OnDisable()
    {
        input.ControllingPawn.Disable();
    }
}
