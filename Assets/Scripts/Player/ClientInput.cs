using UnityEngine;

public class ClientInputCatcher : MonoBehaviour
{
    private PlayerInput input;

    private void Awake()
    {
        input = new PlayerInput();

        input.ControllingPawn.movement.performed += OnMovementPerformedAndCancelled;
        input.ControllingPawn.movement.canceled += OnMovementPerformedAndCancelled;
    }

    private void OnMovementPerformedAndCancelled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        Debug.Log(obj.ReadValue<Vector2>());
    }

    public void Enable()
    {
        input.ControllingPawn.Enable();
    }

    public void Disable()
    {
        input.ControllingPawn.Disable();
    }
}
