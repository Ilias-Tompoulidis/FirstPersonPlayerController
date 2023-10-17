// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerInput.inputactions'

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
            ""name"": ""Default"",
            ""id"": ""057de355-0ce9-4ce8-a696-14443f4cc2e5"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""0a9bbb56-b591-4a48-bf76-db3970ae2d56"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseInput"",
                    ""type"": ""Value"",
                    ""id"": ""449f7a64-0e07-4537-80d5-6eab10aa8285"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""35426852-2d38-4d1e-8728-0f46ed8a8049"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""10daf334-f030-4ff8-8568-2a7f64495ad6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""c4b9c601-26fe-4369-bb14-47f5b2ec7e79"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""5141b732-b999-414e-821e-80b5abc2815e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""11a2d099-a7c8-40f7-8d80-df2c7425edb0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e261996c-7e73-438d-8f71-1c4e21fe01ca"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c34fb9c5-d127-4fc3-b30b-f97d2af37ccc"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c3915c5d-7300-45d7-bb79-469043fe9b85"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8868f1b4-d39b-4256-abf6-a3061f2161db"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b2733c14-12bd-4414-a820-f5ebf8f50985"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b644a731-286c-4754-ac31-9ebeb8f898f8"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""10c494d1-f32d-44ac-b515-ea91a610d4fb"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""04126fc1-d764-4782-a014-3d1aeeb6aa3d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4fe70398-34ae-4781-95ea-496c5b320e4d"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Default
        m_Default = asset.FindActionMap("Default", throwIfNotFound: true);
        m_Default_Movement = m_Default.FindAction("Movement", throwIfNotFound: true);
        m_Default_MouseInput = m_Default.FindAction("MouseInput", throwIfNotFound: true);
        m_Default_Sprint = m_Default.FindAction("Sprint", throwIfNotFound: true);
        m_Default_Jump = m_Default.FindAction("Jump", throwIfNotFound: true);
        m_Default_Aim = m_Default.FindAction("Aim", throwIfNotFound: true);
        m_Default_Fire = m_Default.FindAction("Fire", throwIfNotFound: true);
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

    // Default
    private readonly InputActionMap m_Default;
    private IDefaultActions m_DefaultActionsCallbackInterface;
    private readonly InputAction m_Default_Movement;
    private readonly InputAction m_Default_MouseInput;
    private readonly InputAction m_Default_Sprint;
    private readonly InputAction m_Default_Jump;
    private readonly InputAction m_Default_Aim;
    private readonly InputAction m_Default_Fire;
    public struct DefaultActions
    {
        private @PlayerInput m_Wrapper;
        public DefaultActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Default_Movement;
        public InputAction @MouseInput => m_Wrapper.m_Default_MouseInput;
        public InputAction @Sprint => m_Wrapper.m_Default_Sprint;
        public InputAction @Jump => m_Wrapper.m_Default_Jump;
        public InputAction @Aim => m_Wrapper.m_Default_Aim;
        public InputAction @Fire => m_Wrapper.m_Default_Fire;
        public InputActionMap Get() { return m_Wrapper.m_Default; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefaultActions set) { return set.Get(); }
        public void SetCallbacks(IDefaultActions instance)
        {
            if (m_Wrapper.m_DefaultActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMovement;
                @MouseInput.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMouseInput;
                @MouseInput.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMouseInput;
                @MouseInput.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMouseInput;
                @Sprint.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnSprint;
                @Jump.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnJump;
                @Aim.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnAim;
                @Fire.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnFire;
            }
            m_Wrapper.m_DefaultActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @MouseInput.started += instance.OnMouseInput;
                @MouseInput.performed += instance.OnMouseInput;
                @MouseInput.canceled += instance.OnMouseInput;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
            }
        }
    }
    public DefaultActions @Default => new DefaultActions(this);
    public interface IDefaultActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnMouseInput(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
    }
}
