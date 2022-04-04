// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""5f452642-da78-415e-bc90-191147a92c6c"",
            ""actions"": [
                {
                    ""name"": ""SwitchGatling"",
                    ""type"": ""Button"",
                    ""id"": ""4dec5eae-3ab7-403d-a3e8-a3aba7d9169e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchLaser"",
                    ""type"": ""Button"",
                    ""id"": ""6c3f217f-6608-4edb-bf6a-91c192f20188"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchGrenade"",
                    ""type"": ""Button"",
                    ""id"": ""e575fba6-b0fb-47ed-a62e-7b013815a531"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchBlade"",
                    ""type"": ""Button"",
                    ""id"": ""36425815-4c81-44da-aafc-af3eb76be890"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LookStick"",
                    ""type"": ""Value"",
                    ""id"": ""6236b98a-4ba5-4f98-aba2-6da6b7607069"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveStick"",
                    ""type"": ""Value"",
                    ""id"": ""a9683e04-dc21-4ed8-a8bd-c3d1cddcf8df"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LookMouse"",
                    ""type"": ""Value"",
                    ""id"": ""82bff1a3-78a8-4a55-8064-f979d7d0acf8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HeatAbility"",
                    ""type"": ""Button"",
                    ""id"": ""36c160b7-0c54-4d99-a1fe-55e19e03360c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""0c4adacd-a8d6-46f2-b003-2732b343d860"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveWASD"",
                    ""type"": ""Button"",
                    ""id"": ""7f0ae7d1-f4bb-49eb-9900-055b7f39a2bf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchPlus"",
                    ""type"": ""Button"",
                    ""id"": ""e262809c-5822-4491-8205-037a47cdd7df"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchMinus"",
                    ""type"": ""Button"",
                    ""id"": ""1f127cb5-bf71-41c1-af17-dace3ff22d4a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""73ac2c1c-b2a3-49e3-8de9-a3c6e799117d"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchGatling"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""643a865a-0879-4b61-877f-1d7492eed630"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchGatling"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a4e4fa4-43ac-4435-8eb5-ac692063d015"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchLaser"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72200223-6a08-4ff7-8dd6-cbbee102c6a0"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchLaser"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b70651d6-6257-40e8-aecd-273143b0b3c8"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchGrenade"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ca41a9b7-c750-457e-95b3-cd79007fab49"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchGrenade"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""13b54675-c918-4866-8498-5e9f1a760c95"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchBlade"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7606eafb-00f9-468b-bc1e-72aae6c33064"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchBlade"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""882ff774-74de-4a25-8072-24945e605864"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f2390829-cee0-4445-b016-7793374629f5"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LookStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""68bc6969-4f57-4d45-9b56-c23e164fdca8"",
                    ""path"": ""<Pointer>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LookMouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb945e55-a327-41e5-b12d-647f958fda19"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HeatAbility"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b1aabe66-b80c-48a0-a35d-f3ddcce92117"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HeatAbility"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17f2fcb8-c96e-4007-96c4-ebb112e931ef"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d98e2dc-4096-4499-a493-39de3abbdc27"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""f8e17836-6741-4105-bb4e-d580cc28d346"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveWASD"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""98c92965-a327-4fd9-bdf8-d68163a324c3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveWASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c2ebe982-ebb9-46db-af02-6c206fe8045b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveWASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0cc05d70-fd6d-4264-bc10-d81d3a9dadd2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveWASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a7b7b650-f968-42b6-aee5-256ec55da4af"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveWASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c315e1de-c36d-4122-91bb-c2d9a0cfaf1b"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchPlus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8dda180-5031-405c-ac7a-39881984910a"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchMinus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_SwitchGatling = m_Gameplay.FindAction("SwitchGatling", throwIfNotFound: true);
        m_Gameplay_SwitchLaser = m_Gameplay.FindAction("SwitchLaser", throwIfNotFound: true);
        m_Gameplay_SwitchGrenade = m_Gameplay.FindAction("SwitchGrenade", throwIfNotFound: true);
        m_Gameplay_SwitchBlade = m_Gameplay.FindAction("SwitchBlade", throwIfNotFound: true);
        m_Gameplay_LookStick = m_Gameplay.FindAction("LookStick", throwIfNotFound: true);
        m_Gameplay_MoveStick = m_Gameplay.FindAction("MoveStick", throwIfNotFound: true);
        m_Gameplay_LookMouse = m_Gameplay.FindAction("LookMouse", throwIfNotFound: true);
        m_Gameplay_HeatAbility = m_Gameplay.FindAction("HeatAbility", throwIfNotFound: true);
        m_Gameplay_Fire = m_Gameplay.FindAction("Fire", throwIfNotFound: true);
        m_Gameplay_MoveWASD = m_Gameplay.FindAction("MoveWASD", throwIfNotFound: true);
        m_Gameplay_SwitchPlus = m_Gameplay.FindAction("SwitchPlus", throwIfNotFound: true);
        m_Gameplay_SwitchMinus = m_Gameplay.FindAction("SwitchMinus", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_SwitchGatling;
    private readonly InputAction m_Gameplay_SwitchLaser;
    private readonly InputAction m_Gameplay_SwitchGrenade;
    private readonly InputAction m_Gameplay_SwitchBlade;
    private readonly InputAction m_Gameplay_LookStick;
    private readonly InputAction m_Gameplay_MoveStick;
    private readonly InputAction m_Gameplay_LookMouse;
    private readonly InputAction m_Gameplay_HeatAbility;
    private readonly InputAction m_Gameplay_Fire;
    private readonly InputAction m_Gameplay_MoveWASD;
    private readonly InputAction m_Gameplay_SwitchPlus;
    private readonly InputAction m_Gameplay_SwitchMinus;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @SwitchGatling => m_Wrapper.m_Gameplay_SwitchGatling;
        public InputAction @SwitchLaser => m_Wrapper.m_Gameplay_SwitchLaser;
        public InputAction @SwitchGrenade => m_Wrapper.m_Gameplay_SwitchGrenade;
        public InputAction @SwitchBlade => m_Wrapper.m_Gameplay_SwitchBlade;
        public InputAction @LookStick => m_Wrapper.m_Gameplay_LookStick;
        public InputAction @MoveStick => m_Wrapper.m_Gameplay_MoveStick;
        public InputAction @LookMouse => m_Wrapper.m_Gameplay_LookMouse;
        public InputAction @HeatAbility => m_Wrapper.m_Gameplay_HeatAbility;
        public InputAction @Fire => m_Wrapper.m_Gameplay_Fire;
        public InputAction @MoveWASD => m_Wrapper.m_Gameplay_MoveWASD;
        public InputAction @SwitchPlus => m_Wrapper.m_Gameplay_SwitchPlus;
        public InputAction @SwitchMinus => m_Wrapper.m_Gameplay_SwitchMinus;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @SwitchGatling.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSwitchGatling;
                @SwitchGatling.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSwitchGatling;
                @SwitchGatling.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSwitchGatling;
                @SwitchLaser.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSwitchLaser;
                @SwitchLaser.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSwitchLaser;
                @SwitchLaser.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSwitchLaser;
                @SwitchGrenade.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSwitchGrenade;
                @SwitchGrenade.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSwitchGrenade;
                @SwitchGrenade.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSwitchGrenade;
                @SwitchBlade.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSwitchBlade;
                @SwitchBlade.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSwitchBlade;
                @SwitchBlade.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSwitchBlade;
                @LookStick.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLookStick;
                @LookStick.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLookStick;
                @LookStick.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLookStick;
                @MoveStick.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveStick;
                @MoveStick.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveStick;
                @MoveStick.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveStick;
                @LookMouse.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLookMouse;
                @LookMouse.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLookMouse;
                @LookMouse.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLookMouse;
                @HeatAbility.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnHeatAbility;
                @HeatAbility.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnHeatAbility;
                @HeatAbility.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnHeatAbility;
                @Fire.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFire;
                @MoveWASD.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveWASD;
                @MoveWASD.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveWASD;
                @MoveWASD.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveWASD;
                @SwitchPlus.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSwitchPlus;
                @SwitchPlus.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSwitchPlus;
                @SwitchPlus.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSwitchPlus;
                @SwitchMinus.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSwitchMinus;
                @SwitchMinus.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSwitchMinus;
                @SwitchMinus.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSwitchMinus;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SwitchGatling.started += instance.OnSwitchGatling;
                @SwitchGatling.performed += instance.OnSwitchGatling;
                @SwitchGatling.canceled += instance.OnSwitchGatling;
                @SwitchLaser.started += instance.OnSwitchLaser;
                @SwitchLaser.performed += instance.OnSwitchLaser;
                @SwitchLaser.canceled += instance.OnSwitchLaser;
                @SwitchGrenade.started += instance.OnSwitchGrenade;
                @SwitchGrenade.performed += instance.OnSwitchGrenade;
                @SwitchGrenade.canceled += instance.OnSwitchGrenade;
                @SwitchBlade.started += instance.OnSwitchBlade;
                @SwitchBlade.performed += instance.OnSwitchBlade;
                @SwitchBlade.canceled += instance.OnSwitchBlade;
                @LookStick.started += instance.OnLookStick;
                @LookStick.performed += instance.OnLookStick;
                @LookStick.canceled += instance.OnLookStick;
                @MoveStick.started += instance.OnMoveStick;
                @MoveStick.performed += instance.OnMoveStick;
                @MoveStick.canceled += instance.OnMoveStick;
                @LookMouse.started += instance.OnLookMouse;
                @LookMouse.performed += instance.OnLookMouse;
                @LookMouse.canceled += instance.OnLookMouse;
                @HeatAbility.started += instance.OnHeatAbility;
                @HeatAbility.performed += instance.OnHeatAbility;
                @HeatAbility.canceled += instance.OnHeatAbility;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @MoveWASD.started += instance.OnMoveWASD;
                @MoveWASD.performed += instance.OnMoveWASD;
                @MoveWASD.canceled += instance.OnMoveWASD;
                @SwitchPlus.started += instance.OnSwitchPlus;
                @SwitchPlus.performed += instance.OnSwitchPlus;
                @SwitchPlus.canceled += instance.OnSwitchPlus;
                @SwitchMinus.started += instance.OnSwitchMinus;
                @SwitchMinus.performed += instance.OnSwitchMinus;
                @SwitchMinus.canceled += instance.OnSwitchMinus;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnSwitchGatling(InputAction.CallbackContext context);
        void OnSwitchLaser(InputAction.CallbackContext context);
        void OnSwitchGrenade(InputAction.CallbackContext context);
        void OnSwitchBlade(InputAction.CallbackContext context);
        void OnLookStick(InputAction.CallbackContext context);
        void OnMoveStick(InputAction.CallbackContext context);
        void OnLookMouse(InputAction.CallbackContext context);
        void OnHeatAbility(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnMoveWASD(InputAction.CallbackContext context);
        void OnSwitchPlus(InputAction.CallbackContext context);
        void OnSwitchMinus(InputAction.CallbackContext context);
    }
}
