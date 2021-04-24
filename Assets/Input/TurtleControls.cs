// GENERATED AUTOMATICALLY FROM 'Assets/Input/TurtleControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @TurtleControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @TurtleControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TurtleControls"",
    ""maps"": [
        {
            ""name"": ""Controls"",
            ""id"": ""18f1d50c-aee7-457b-a181-dcf41056b113"",
            ""actions"": [
                {
                    ""name"": ""ForwardKeyboard"",
                    ""type"": ""Value"",
                    ""id"": ""b7f35f63-44e6-4c35-af65-f3472a42adb8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateKeyboard"",
                    ""type"": ""Value"",
                    ""id"": ""2ec40afa-0577-4dc4-a3b0-cd7bc75e0665"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""611b584b-8ed6-4548-a803-0e62241378f1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""f4b4b5bc-858a-49b0-bdd6-95ded1334306"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ForwardController"",
                    ""type"": ""Value"",
                    ""id"": ""3049ab49-9f75-4979-bda0-992f4ce7e5eb"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BackwardController"",
                    ""type"": ""Value"",
                    ""id"": ""397dd53e-a02e-42a4-970c-50e37bdd0535"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateController"",
                    ""type"": ""Value"",
                    ""id"": ""a912034b-e20e-49fa-a9c3-7d9ce9e3b922"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Handbrake"",
                    ""type"": ""Value"",
                    ""id"": ""0fdd9daf-050e-4140-85df-6110241d4583"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.1,pressPoint=0.1)""
                },
                {
                    ""name"": ""Respawn"",
                    ""type"": ""Button"",
                    ""id"": ""b71c3410-b904-42e0-8672-9f48dfd0d946"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.1,pressPoint=0.1)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WS"",
                    ""id"": ""399625a9-191c-4d08-9a46-f1505feff63d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardKeyboard"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""bdbc2a0d-4000-4f4c-9c3d-ea3db8f9d783"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Controls"",
                    ""action"": ""ForwardKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""1e838598-9959-4315-acb3-e147b4e58226"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Controls"",
                    ""action"": ""ForwardKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9ee271c3-a76e-4dd0-9f00-009f7b24f69b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Controls"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7b923103-7257-44e2-851a-fc4c124bcdb1"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Controls"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e75fd23-7cf1-462e-bb8c-5ce429ba934a"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Controls"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f399e77b-ea1d-43fe-9e3b-80404d0049e4"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Controls"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""AD"",
                    ""id"": ""334351cd-f797-4b17-b3a8-e8f3b022ae42"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateKeyboard"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1cb5c834-a616-472f-8b17-5901bfa3534f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Controls"",
                    ""action"": ""RotateKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6bafb113-7a0b-4f2d-9620-9d4f92bccff3"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Controls"",
                    ""action"": ""RotateKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c6af59b1-dae4-455a-b3ef-9df5333e2ec8"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Controls"",
                    ""action"": ""ForwardController"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51fd1b5c-be08-4c4a-836b-a2e0462caca3"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Controls"",
                    ""action"": ""BackwardController"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20fd0b01-cc38-4ff0-ba12-545806514f98"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Controls"",
                    ""action"": ""RotateController"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""014e24b7-5d70-4e82-b1d7-f496bdd5559d"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Controls"",
                    ""action"": ""RotateController"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3759f0f6-d659-45d6-ba41-c8590d78f93d"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Controls"",
                    ""action"": ""Handbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f7b57d26-d575-445c-9dbc-4b2dd62639fe"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Controls"",
                    ""action"": ""Handbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""52c22411-c7ab-47f3-83b4-2f341c9211e4"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Controls"",
                    ""action"": ""Respawn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e49850e1-b213-4db3-b23b-0b4f5f92c667"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Controls"",
                    ""action"": ""Respawn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard Controls"",
            ""bindingGroup"": ""Keyboard Controls"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad Controls"",
            ""bindingGroup"": ""Gamepad Controls"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Controls
        m_Controls = asset.FindActionMap("Controls", throwIfNotFound: true);
        m_Controls_ForwardKeyboard = m_Controls.FindAction("ForwardKeyboard", throwIfNotFound: true);
        m_Controls_RotateKeyboard = m_Controls.FindAction("RotateKeyboard", throwIfNotFound: true);
        m_Controls_Jump = m_Controls.FindAction("Jump", throwIfNotFound: true);
        m_Controls_Pause = m_Controls.FindAction("Pause", throwIfNotFound: true);
        m_Controls_ForwardController = m_Controls.FindAction("ForwardController", throwIfNotFound: true);
        m_Controls_BackwardController = m_Controls.FindAction("BackwardController", throwIfNotFound: true);
        m_Controls_RotateController = m_Controls.FindAction("RotateController", throwIfNotFound: true);
        m_Controls_Handbrake = m_Controls.FindAction("Handbrake", throwIfNotFound: true);
        m_Controls_Respawn = m_Controls.FindAction("Respawn", throwIfNotFound: true);
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

    // Controls
    private readonly InputActionMap m_Controls;
    private IControlsActions m_ControlsActionsCallbackInterface;
    private readonly InputAction m_Controls_ForwardKeyboard;
    private readonly InputAction m_Controls_RotateKeyboard;
    private readonly InputAction m_Controls_Jump;
    private readonly InputAction m_Controls_Pause;
    private readonly InputAction m_Controls_ForwardController;
    private readonly InputAction m_Controls_BackwardController;
    private readonly InputAction m_Controls_RotateController;
    private readonly InputAction m_Controls_Handbrake;
    private readonly InputAction m_Controls_Respawn;
    public struct ControlsActions
    {
        private @TurtleControls m_Wrapper;
        public ControlsActions(@TurtleControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @ForwardKeyboard => m_Wrapper.m_Controls_ForwardKeyboard;
        public InputAction @RotateKeyboard => m_Wrapper.m_Controls_RotateKeyboard;
        public InputAction @Jump => m_Wrapper.m_Controls_Jump;
        public InputAction @Pause => m_Wrapper.m_Controls_Pause;
        public InputAction @ForwardController => m_Wrapper.m_Controls_ForwardController;
        public InputAction @BackwardController => m_Wrapper.m_Controls_BackwardController;
        public InputAction @RotateController => m_Wrapper.m_Controls_RotateController;
        public InputAction @Handbrake => m_Wrapper.m_Controls_Handbrake;
        public InputAction @Respawn => m_Wrapper.m_Controls_Respawn;
        public InputActionMap Get() { return m_Wrapper.m_Controls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControlsActions set) { return set.Get(); }
        public void SetCallbacks(IControlsActions instance)
        {
            if (m_Wrapper.m_ControlsActionsCallbackInterface != null)
            {
                @ForwardKeyboard.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnForwardKeyboard;
                @ForwardKeyboard.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnForwardKeyboard;
                @ForwardKeyboard.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnForwardKeyboard;
                @RotateKeyboard.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnRotateKeyboard;
                @RotateKeyboard.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnRotateKeyboard;
                @RotateKeyboard.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnRotateKeyboard;
                @Jump.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnJump;
                @Pause.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnPause;
                @ForwardController.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnForwardController;
                @ForwardController.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnForwardController;
                @ForwardController.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnForwardController;
                @BackwardController.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnBackwardController;
                @BackwardController.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnBackwardController;
                @BackwardController.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnBackwardController;
                @RotateController.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnRotateController;
                @RotateController.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnRotateController;
                @RotateController.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnRotateController;
                @Handbrake.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnHandbrake;
                @Handbrake.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnHandbrake;
                @Handbrake.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnHandbrake;
                @Respawn.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnRespawn;
                @Respawn.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnRespawn;
                @Respawn.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnRespawn;
            }
            m_Wrapper.m_ControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ForwardKeyboard.started += instance.OnForwardKeyboard;
                @ForwardKeyboard.performed += instance.OnForwardKeyboard;
                @ForwardKeyboard.canceled += instance.OnForwardKeyboard;
                @RotateKeyboard.started += instance.OnRotateKeyboard;
                @RotateKeyboard.performed += instance.OnRotateKeyboard;
                @RotateKeyboard.canceled += instance.OnRotateKeyboard;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @ForwardController.started += instance.OnForwardController;
                @ForwardController.performed += instance.OnForwardController;
                @ForwardController.canceled += instance.OnForwardController;
                @BackwardController.started += instance.OnBackwardController;
                @BackwardController.performed += instance.OnBackwardController;
                @BackwardController.canceled += instance.OnBackwardController;
                @RotateController.started += instance.OnRotateController;
                @RotateController.performed += instance.OnRotateController;
                @RotateController.canceled += instance.OnRotateController;
                @Handbrake.started += instance.OnHandbrake;
                @Handbrake.performed += instance.OnHandbrake;
                @Handbrake.canceled += instance.OnHandbrake;
                @Respawn.started += instance.OnRespawn;
                @Respawn.performed += instance.OnRespawn;
                @Respawn.canceled += instance.OnRespawn;
            }
        }
    }
    public ControlsActions @Controls => new ControlsActions(this);
    private int m_KeyboardControlsSchemeIndex = -1;
    public InputControlScheme KeyboardControlsScheme
    {
        get
        {
            if (m_KeyboardControlsSchemeIndex == -1) m_KeyboardControlsSchemeIndex = asset.FindControlSchemeIndex("Keyboard Controls");
            return asset.controlSchemes[m_KeyboardControlsSchemeIndex];
        }
    }
    private int m_GamepadControlsSchemeIndex = -1;
    public InputControlScheme GamepadControlsScheme
    {
        get
        {
            if (m_GamepadControlsSchemeIndex == -1) m_GamepadControlsSchemeIndex = asset.FindControlSchemeIndex("Gamepad Controls");
            return asset.controlSchemes[m_GamepadControlsSchemeIndex];
        }
    }
    public interface IControlsActions
    {
        void OnForwardKeyboard(InputAction.CallbackContext context);
        void OnRotateKeyboard(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnForwardController(InputAction.CallbackContext context);
        void OnBackwardController(InputAction.CallbackContext context);
        void OnRotateController(InputAction.CallbackContext context);
        void OnHandbrake(InputAction.CallbackContext context);
        void OnRespawn(InputAction.CallbackContext context);
    }
}
