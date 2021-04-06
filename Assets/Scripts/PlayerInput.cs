// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerInput.inputactions'

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
            ""name"": ""PlayerShip"",
            ""id"": ""bbf188e3-1b6b-48cb-a91a-736262c3083c"",
            ""actions"": [
                {
                    ""name"": ""MoveForward"",
                    ""type"": ""Button"",
                    ""id"": ""c5bfb229-6cec-49ce-b557-02837a6a4420"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Torque"",
                    ""type"": ""Value"",
                    ""id"": ""5bdc3645-967d-45f6-9f6f-7edc95000aee"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""22a9444b-edfa-4632-8e7f-37d492a6a929"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrows"",
                    ""id"": ""f69f9e85-f879-47c2-91d7-ae6fbd23bf26"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveForward"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d9c14206-7b4b-42c9-9eb7-87705e11589e"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Wasd"",
                    ""id"": ""5421fdbb-2211-4cd6-bebf-877c973ca713"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveForward"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""572800a1-acb5-4151-92dd-317023ea2a0f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e102732f-d36a-4daa-99b5-d608d5905e3d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""22439da8-2f5c-4215-b10b-f206afc48765"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Torque"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ac1639eb-a636-4267-86c6-3759ef5c1a64"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Torque"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a3ec7a09-2dea-4018-9f1d-c62d5affea25"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Torque"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerShip
        m_PlayerShip = asset.FindActionMap("PlayerShip", throwIfNotFound: true);
        m_PlayerShip_MoveForward = m_PlayerShip.FindAction("MoveForward", throwIfNotFound: true);
        m_PlayerShip_Torque = m_PlayerShip.FindAction("Torque", throwIfNotFound: true);
        m_PlayerShip_Shoot = m_PlayerShip.FindAction("Shoot", throwIfNotFound: true);
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

    // PlayerShip
    private readonly InputActionMap m_PlayerShip;
    private IPlayerShipActions m_PlayerShipActionsCallbackInterface;
    private readonly InputAction m_PlayerShip_MoveForward;
    private readonly InputAction m_PlayerShip_Torque;
    private readonly InputAction m_PlayerShip_Shoot;
    public struct PlayerShipActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerShipActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveForward => m_Wrapper.m_PlayerShip_MoveForward;
        public InputAction @Torque => m_Wrapper.m_PlayerShip_Torque;
        public InputAction @Shoot => m_Wrapper.m_PlayerShip_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_PlayerShip; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerShipActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerShipActions instance)
        {
            if (m_Wrapper.m_PlayerShipActionsCallbackInterface != null)
            {
                @MoveForward.started -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnMoveForward;
                @MoveForward.performed -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnMoveForward;
                @MoveForward.canceled -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnMoveForward;
                @Torque.started -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnTorque;
                @Torque.performed -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnTorque;
                @Torque.canceled -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnTorque;
                @Shoot.started -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_PlayerShipActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveForward.started += instance.OnMoveForward;
                @MoveForward.performed += instance.OnMoveForward;
                @MoveForward.canceled += instance.OnMoveForward;
                @Torque.started += instance.OnTorque;
                @Torque.performed += instance.OnTorque;
                @Torque.canceled += instance.OnTorque;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
            }
        }
    }
    public PlayerShipActions @PlayerShip => new PlayerShipActions(this);
    public interface IPlayerShipActions
    {
        void OnMoveForward(InputAction.CallbackContext context);
        void OnTorque(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
}
