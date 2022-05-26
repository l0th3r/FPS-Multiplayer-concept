// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""ControllingPawn"",
            ""id"": ""c114ab53-3347-4122-8334-eedb4de77921"",
            ""actions"": [
                {
                    ""name"": ""movement"",
                    ""type"": ""Value"",
                    ""id"": ""42bdde21-cd71-4217-a05d-421d519ad61c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""looking"",
                    ""type"": ""Value"",
                    ""id"": ""610e64f4-0ff9-4a7d-9008-0f0fe316c299"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""QWERTY"",
                    ""id"": ""02faf8b4-472c-4613-8a78-224c77543aaf"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""dea4328d-ea24-4af2-aed6-e4de92d90437"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2e91dcbf-e94d-4225-b548-fd6f56e9a921"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c7fe0ad7-58be-4ed3-b82c-8347a0f19900"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ea5b8bad-72b6-4e87-8fe8-db62f3c5790b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""21026901-3a28-4aab-b527-3a92f7f4ae6b"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""looking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ControllingPawn
        m_ControllingPawn = asset.FindActionMap("ControllingPawn", throwIfNotFound: true);
        m_ControllingPawn_movement = m_ControllingPawn.FindAction("movement", throwIfNotFound: true);
        m_ControllingPawn_looking = m_ControllingPawn.FindAction("looking", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // ControllingPawn
    private readonly InputActionMap m_ControllingPawn;
    private IControllingPawnActions m_ControllingPawnActionsCallbackInterface;
    private readonly InputAction m_ControllingPawn_movement;
    private readonly InputAction m_ControllingPawn_looking;
    public struct ControllingPawnActions
    {
        private @PlayerInput m_Wrapper;
        public ControllingPawnActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @movement => m_Wrapper.m_ControllingPawn_movement;
        public InputAction @looking => m_Wrapper.m_ControllingPawn_looking;
        public InputActionMap Get() { return m_Wrapper.m_ControllingPawn; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControllingPawnActions set) { return set.Get(); }
        public void SetCallbacks(IControllingPawnActions instance)
        {
            if (m_Wrapper.m_ControllingPawnActionsCallbackInterface != null)
            {
                @movement.started -= m_Wrapper.m_ControllingPawnActionsCallbackInterface.OnMovement;
                @movement.performed -= m_Wrapper.m_ControllingPawnActionsCallbackInterface.OnMovement;
                @movement.canceled -= m_Wrapper.m_ControllingPawnActionsCallbackInterface.OnMovement;
                @looking.started -= m_Wrapper.m_ControllingPawnActionsCallbackInterface.OnLooking;
                @looking.performed -= m_Wrapper.m_ControllingPawnActionsCallbackInterface.OnLooking;
                @looking.canceled -= m_Wrapper.m_ControllingPawnActionsCallbackInterface.OnLooking;
            }
            m_Wrapper.m_ControllingPawnActionsCallbackInterface = instance;
            if (instance != null)
            {
                @movement.started += instance.OnMovement;
                @movement.performed += instance.OnMovement;
                @movement.canceled += instance.OnMovement;
                @looking.started += instance.OnLooking;
                @looking.performed += instance.OnLooking;
                @looking.canceled += instance.OnLooking;
            }
        }
    }
    public ControllingPawnActions @ControllingPawn => new ControllingPawnActions(this);
    public interface IControllingPawnActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnLooking(InputAction.CallbackContext context);
    }
}
