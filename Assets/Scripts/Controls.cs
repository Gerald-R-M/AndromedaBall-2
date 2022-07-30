//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Controls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""PlayerControls"",
            ""id"": ""713eea7e-9fcb-4fb7-884e-a4bf31083c38"",
            ""actions"": [
                {
                    ""name"": ""P1_Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""78ad987d-bcae-4569-b256-5c0d0731dc29"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""P1_Ability1"",
                    ""type"": ""Button"",
                    ""id"": ""e0c9f44e-492a-405d-baf3-2c597f6196fc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""P1_Ability2"",
                    ""type"": ""Button"",
                    ""id"": ""14f98973-3ab5-49d6-91b9-2ba34ce9d06e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""P1_Swing"",
                    ""type"": ""Button"",
                    ""id"": ""8089b634-4f82-4665-b77f-89c1b4089f46"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""P2_Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""00b6c4cb-2150-4277-8717-6e1df1e25524"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""P2_Ability1"",
                    ""type"": ""Button"",
                    ""id"": ""77d3fbfb-8ec8-408c-a461-b8a37a2e0a5c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""P2_Ability2"",
                    ""type"": ""Button"",
                    ""id"": ""9bc665a7-dc8c-47a6-9b77-3bd3338d7be7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""P2_Swing"",
                    ""type"": ""Button"",
                    ""id"": ""1f1d1283-d702-4cf4-b573-5f4c6af05b48"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""0a5919df-6e98-4407-9f54-dc162987d1bd"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""P1_Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""eea587aa-424a-4bc5-b376-8e8187a6f004"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""P1_Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7372fa3d-8889-4268-b7e4-7d389bf1146f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""P1_Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4c5bd7b4-f4e7-46ff-ab42-73a6b82b7927"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""P1_Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""388f383f-72ea-46c8-954d-37815c181252"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""P1_Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e0534b18-670b-4dd9-8ffe-664b45f89a94"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""P1_Ability1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""099807a3-630f-4da4-9f9d-992daf860ccf"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""P1_Swing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""91585c27-db44-4326-9129-e5aaeb85ead5"",
                    ""path"": ""<Keyboard>/comma"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""P2_Swing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""b4b932f4-965d-461f-9ea9-ad5016440209"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""P2_Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""079c5812-4add-4720-a9d9-8a3a7f8324e4"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""P2_Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""299c6fd0-c6ad-43a7-a910-68b79ebf568e"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""P2_Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""aca08cd7-7e6b-419d-be5e-19913cd9ceca"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""P2_Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b2d0d161-faab-497a-9d64-989e5d72ad39"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""P2_Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fde9d15e-7201-4c16-a9be-8f814ef23aaf"",
                    ""path"": ""<Keyboard>/period"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""P2_Ability1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9988034c-888a-465c-9593-13d46a787640"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""P1_Ability2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96e4e40a-3f7a-4f08-9ed8-70f171f4a11e"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""P2_Ability2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerControls
        m_PlayerControls = asset.FindActionMap("PlayerControls", throwIfNotFound: true);
        m_PlayerControls_P1_Movement = m_PlayerControls.FindAction("P1_Movement", throwIfNotFound: true);
        m_PlayerControls_P1_Ability1 = m_PlayerControls.FindAction("P1_Ability1", throwIfNotFound: true);
        m_PlayerControls_P1_Ability2 = m_PlayerControls.FindAction("P1_Ability2", throwIfNotFound: true);
        m_PlayerControls_P1_Swing = m_PlayerControls.FindAction("P1_Swing", throwIfNotFound: true);
        m_PlayerControls_P2_Movement = m_PlayerControls.FindAction("P2_Movement", throwIfNotFound: true);
        m_PlayerControls_P2_Ability1 = m_PlayerControls.FindAction("P2_Ability1", throwIfNotFound: true);
        m_PlayerControls_P2_Ability2 = m_PlayerControls.FindAction("P2_Ability2", throwIfNotFound: true);
        m_PlayerControls_P2_Swing = m_PlayerControls.FindAction("P2_Swing", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerControls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_P1_Movement;
    private readonly InputAction m_PlayerControls_P1_Ability1;
    private readonly InputAction m_PlayerControls_P1_Ability2;
    private readonly InputAction m_PlayerControls_P1_Swing;
    private readonly InputAction m_PlayerControls_P2_Movement;
    private readonly InputAction m_PlayerControls_P2_Ability1;
    private readonly InputAction m_PlayerControls_P2_Ability2;
    private readonly InputAction m_PlayerControls_P2_Swing;
    public struct PlayerControlsActions
    {
        private @Controls m_Wrapper;
        public PlayerControlsActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @P1_Movement => m_Wrapper.m_PlayerControls_P1_Movement;
        public InputAction @P1_Ability1 => m_Wrapper.m_PlayerControls_P1_Ability1;
        public InputAction @P1_Ability2 => m_Wrapper.m_PlayerControls_P1_Ability2;
        public InputAction @P1_Swing => m_Wrapper.m_PlayerControls_P1_Swing;
        public InputAction @P2_Movement => m_Wrapper.m_PlayerControls_P2_Movement;
        public InputAction @P2_Ability1 => m_Wrapper.m_PlayerControls_P2_Ability1;
        public InputAction @P2_Ability2 => m_Wrapper.m_PlayerControls_P2_Ability2;
        public InputAction @P2_Swing => m_Wrapper.m_PlayerControls_P2_Swing;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @P1_Movement.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP1_Movement;
                @P1_Movement.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP1_Movement;
                @P1_Movement.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP1_Movement;
                @P1_Ability1.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP1_Ability1;
                @P1_Ability1.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP1_Ability1;
                @P1_Ability1.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP1_Ability1;
                @P1_Ability2.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP1_Ability2;
                @P1_Ability2.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP1_Ability2;
                @P1_Ability2.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP1_Ability2;
                @P1_Swing.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP1_Swing;
                @P1_Swing.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP1_Swing;
                @P1_Swing.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP1_Swing;
                @P2_Movement.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2_Movement;
                @P2_Movement.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2_Movement;
                @P2_Movement.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2_Movement;
                @P2_Ability1.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2_Ability1;
                @P2_Ability1.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2_Ability1;
                @P2_Ability1.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2_Ability1;
                @P2_Ability2.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2_Ability2;
                @P2_Ability2.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2_Ability2;
                @P2_Ability2.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2_Ability2;
                @P2_Swing.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2_Swing;
                @P2_Swing.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2_Swing;
                @P2_Swing.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2_Swing;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @P1_Movement.started += instance.OnP1_Movement;
                @P1_Movement.performed += instance.OnP1_Movement;
                @P1_Movement.canceled += instance.OnP1_Movement;
                @P1_Ability1.started += instance.OnP1_Ability1;
                @P1_Ability1.performed += instance.OnP1_Ability1;
                @P1_Ability1.canceled += instance.OnP1_Ability1;
                @P1_Ability2.started += instance.OnP1_Ability2;
                @P1_Ability2.performed += instance.OnP1_Ability2;
                @P1_Ability2.canceled += instance.OnP1_Ability2;
                @P1_Swing.started += instance.OnP1_Swing;
                @P1_Swing.performed += instance.OnP1_Swing;
                @P1_Swing.canceled += instance.OnP1_Swing;
                @P2_Movement.started += instance.OnP2_Movement;
                @P2_Movement.performed += instance.OnP2_Movement;
                @P2_Movement.canceled += instance.OnP2_Movement;
                @P2_Ability1.started += instance.OnP2_Ability1;
                @P2_Ability1.performed += instance.OnP2_Ability1;
                @P2_Ability1.canceled += instance.OnP2_Ability1;
                @P2_Ability2.started += instance.OnP2_Ability2;
                @P2_Ability2.performed += instance.OnP2_Ability2;
                @P2_Ability2.canceled += instance.OnP2_Ability2;
                @P2_Swing.started += instance.OnP2_Swing;
                @P2_Swing.performed += instance.OnP2_Swing;
                @P2_Swing.canceled += instance.OnP2_Swing;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IPlayerControlsActions
    {
        void OnP1_Movement(InputAction.CallbackContext context);
        void OnP1_Ability1(InputAction.CallbackContext context);
        void OnP1_Ability2(InputAction.CallbackContext context);
        void OnP1_Swing(InputAction.CallbackContext context);
        void OnP2_Movement(InputAction.CallbackContext context);
        void OnP2_Ability1(InputAction.CallbackContext context);
        void OnP2_Ability2(InputAction.CallbackContext context);
        void OnP2_Swing(InputAction.CallbackContext context);
    }
}
