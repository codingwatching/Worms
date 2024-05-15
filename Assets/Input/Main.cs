//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Input/Main.inputactions
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

public partial class @MainInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MainInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Main"",
    ""maps"": [
        {
            ""name"": ""Weapon"",
            ""id"": ""3fb7eff6-c1c7-4dea-b7a8-a34f5909b57b"",
            ""actions"": [
                {
                    ""name"": ""RaiseScope"",
                    ""type"": ""Value"",
                    ""id"": ""2cabf696-7493-4956-b05b-034942146220"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": ""Hold"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""EnablePointerLine"",
                    ""type"": ""Button"",
                    ""id"": ""ddec274d-7736-4ba1-a0ed-5a25f8c4fe9c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""IncreaseShotPower"",
                    ""type"": ""Button"",
                    ""id"": ""3ea45bfa-a586-4276-97d7-2e2d6a922da0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""f368437f-7ef7-4141-9474-8d087d84aabd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""e307078c-cf86-43f2-ac51-79ec8949ac9c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RaiseScope"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""816c4701-ffda-424c-aa55-6d708551515a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RaiseScope"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2fa1ebe4-8d3f-4cd2-aa6b-820abf3416c8"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RaiseScope"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""b01d6f7b-dc43-4455-b681-2f87eb2dc46b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RaiseScope"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a5c85939-8eb1-46f4-b6a6-5d08b1c6b12c"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RaiseScope"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2bda6e35-2a1a-4dfd-92b5-0e5209ad74a2"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RaiseScope"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""57efd260-928c-4834-b583-b45b68f1821c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnablePointerLine"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d197329-b7fd-4467-bdfe-42eee142abac"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""IncreaseShotPower"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""914e4e10-3c0e-4268-a828-5a235741bf11"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Movement"",
            ""id"": ""e0da62a6-02dd-42db-8990-1c5c2eca847c"",
            ""actions"": [
                {
                    ""name"": ""HighJump"",
                    ""type"": ""Button"",
                    ""id"": ""8608867f-3346-432d-bc39-3621e54a611c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LongJump"",
                    ""type"": ""Button"",
                    ""id"": ""aa8c7bd4-773f-4445-afaf-2d1a8939c3df"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DontMove"",
                    ""type"": ""Button"",
                    ""id"": ""47500124-ab0c-4dc5-ae59-38d84c5be7df"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TurnRight"",
                    ""type"": ""Button"",
                    ""id"": ""d04d3ac7-cdfb-4d2c-a884-149fff1cb7a2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TurnLeft"",
                    ""type"": ""Button"",
                    ""id"": ""cd1e4d8d-9889-409c-ac93-98f5add42f6f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""2058bcde-2eed-4e93-88a7-a489acd338e2"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": ""Hold"",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""7f548e34-3d28-41d9-929f-2ac9f9110f17"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""67563eee-2b0e-46c0-9634-251d23e97be8"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""15add363-4c16-474e-b239-53c5c0536888"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis AD"",
                    ""id"": ""04127d46-7931-4004-a446-88481116051e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""00cd238f-87f7-4abb-801e-5fce1a5cb622"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a1206f35-acc1-476a-b1c4-03172eaa4605"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""b008c50f-0045-4261-a379-d8a5e6505b8b"",
                    ""path"": ""OneModifier"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurnLeft"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""54b96dc1-d4a6-4757-b223-6b4d04f15348"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurnLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""6b3dc109-a465-49b4-90f7-8b1b2ccca098"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurnLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""7bb80b31-af41-4bac-9f8b-da8ceed316e6"",
                    ""path"": ""OneModifier"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurnRight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""1099c387-6704-4464-80cc-e9c6b89b5808"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurnRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""c994632c-ffaf-4f77-af36-16df710630ee"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurnRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bc8eab30-ff41-4e69-9a6a-3b8f15b5f9d1"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DontMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""88a15b33-6daf-4c2c-9c3f-6e05e57cbd11"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LongJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""05a8e012-1970-4044-b97b-6c29e3ba7599"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HighJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Weapon
        m_Weapon = asset.FindActionMap("Weapon", throwIfNotFound: true);
        m_Weapon_RaiseScope = m_Weapon.FindAction("RaiseScope", throwIfNotFound: true);
        m_Weapon_EnablePointerLine = m_Weapon.FindAction("EnablePointerLine", throwIfNotFound: true);
        m_Weapon_IncreaseShotPower = m_Weapon.FindAction("IncreaseShotPower", throwIfNotFound: true);
        m_Weapon_Shoot = m_Weapon.FindAction("Shoot", throwIfNotFound: true);
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_HighJump = m_Movement.FindAction("HighJump", throwIfNotFound: true);
        m_Movement_LongJump = m_Movement.FindAction("LongJump", throwIfNotFound: true);
        m_Movement_DontMove = m_Movement.FindAction("DontMove", throwIfNotFound: true);
        m_Movement_TurnRight = m_Movement.FindAction("TurnRight", throwIfNotFound: true);
        m_Movement_TurnLeft = m_Movement.FindAction("TurnLeft", throwIfNotFound: true);
        m_Movement_Move = m_Movement.FindAction("Move", throwIfNotFound: true);
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

    // Weapon
    private readonly InputActionMap m_Weapon;
    private List<IWeaponActions> m_WeaponActionsCallbackInterfaces = new List<IWeaponActions>();
    private readonly InputAction m_Weapon_RaiseScope;
    private readonly InputAction m_Weapon_EnablePointerLine;
    private readonly InputAction m_Weapon_IncreaseShotPower;
    private readonly InputAction m_Weapon_Shoot;
    public struct WeaponActions
    {
        private @MainInput m_Wrapper;
        public WeaponActions(@MainInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @RaiseScope => m_Wrapper.m_Weapon_RaiseScope;
        public InputAction @EnablePointerLine => m_Wrapper.m_Weapon_EnablePointerLine;
        public InputAction @IncreaseShotPower => m_Wrapper.m_Weapon_IncreaseShotPower;
        public InputAction @Shoot => m_Wrapper.m_Weapon_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_Weapon; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WeaponActions set) { return set.Get(); }
        public void AddCallbacks(IWeaponActions instance)
        {
            if (instance == null || m_Wrapper.m_WeaponActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_WeaponActionsCallbackInterfaces.Add(instance);
            @RaiseScope.started += instance.OnRaiseScope;
            @RaiseScope.performed += instance.OnRaiseScope;
            @RaiseScope.canceled += instance.OnRaiseScope;
            @EnablePointerLine.started += instance.OnEnablePointerLine;
            @EnablePointerLine.performed += instance.OnEnablePointerLine;
            @EnablePointerLine.canceled += instance.OnEnablePointerLine;
            @IncreaseShotPower.started += instance.OnIncreaseShotPower;
            @IncreaseShotPower.performed += instance.OnIncreaseShotPower;
            @IncreaseShotPower.canceled += instance.OnIncreaseShotPower;
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
        }

        private void UnregisterCallbacks(IWeaponActions instance)
        {
            @RaiseScope.started -= instance.OnRaiseScope;
            @RaiseScope.performed -= instance.OnRaiseScope;
            @RaiseScope.canceled -= instance.OnRaiseScope;
            @EnablePointerLine.started -= instance.OnEnablePointerLine;
            @EnablePointerLine.performed -= instance.OnEnablePointerLine;
            @EnablePointerLine.canceled -= instance.OnEnablePointerLine;
            @IncreaseShotPower.started -= instance.OnIncreaseShotPower;
            @IncreaseShotPower.performed -= instance.OnIncreaseShotPower;
            @IncreaseShotPower.canceled -= instance.OnIncreaseShotPower;
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
        }

        public void RemoveCallbacks(IWeaponActions instance)
        {
            if (m_Wrapper.m_WeaponActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IWeaponActions instance)
        {
            foreach (var item in m_Wrapper.m_WeaponActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_WeaponActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public WeaponActions @Weapon => new WeaponActions(this);

    // Movement
    private readonly InputActionMap m_Movement;
    private List<IMovementActions> m_MovementActionsCallbackInterfaces = new List<IMovementActions>();
    private readonly InputAction m_Movement_HighJump;
    private readonly InputAction m_Movement_LongJump;
    private readonly InputAction m_Movement_DontMove;
    private readonly InputAction m_Movement_TurnRight;
    private readonly InputAction m_Movement_TurnLeft;
    private readonly InputAction m_Movement_Move;
    public struct MovementActions
    {
        private @MainInput m_Wrapper;
        public MovementActions(@MainInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @HighJump => m_Wrapper.m_Movement_HighJump;
        public InputAction @LongJump => m_Wrapper.m_Movement_LongJump;
        public InputAction @DontMove => m_Wrapper.m_Movement_DontMove;
        public InputAction @TurnRight => m_Wrapper.m_Movement_TurnRight;
        public InputAction @TurnLeft => m_Wrapper.m_Movement_TurnLeft;
        public InputAction @Move => m_Wrapper.m_Movement_Move;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void AddCallbacks(IMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_MovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MovementActionsCallbackInterfaces.Add(instance);
            @HighJump.started += instance.OnHighJump;
            @HighJump.performed += instance.OnHighJump;
            @HighJump.canceled += instance.OnHighJump;
            @LongJump.started += instance.OnLongJump;
            @LongJump.performed += instance.OnLongJump;
            @LongJump.canceled += instance.OnLongJump;
            @DontMove.started += instance.OnDontMove;
            @DontMove.performed += instance.OnDontMove;
            @DontMove.canceled += instance.OnDontMove;
            @TurnRight.started += instance.OnTurnRight;
            @TurnRight.performed += instance.OnTurnRight;
            @TurnRight.canceled += instance.OnTurnRight;
            @TurnLeft.started += instance.OnTurnLeft;
            @TurnLeft.performed += instance.OnTurnLeft;
            @TurnLeft.canceled += instance.OnTurnLeft;
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(IMovementActions instance)
        {
            @HighJump.started -= instance.OnHighJump;
            @HighJump.performed -= instance.OnHighJump;
            @HighJump.canceled -= instance.OnHighJump;
            @LongJump.started -= instance.OnLongJump;
            @LongJump.performed -= instance.OnLongJump;
            @LongJump.canceled -= instance.OnLongJump;
            @DontMove.started -= instance.OnDontMove;
            @DontMove.performed -= instance.OnDontMove;
            @DontMove.canceled -= instance.OnDontMove;
            @TurnRight.started -= instance.OnTurnRight;
            @TurnRight.performed -= instance.OnTurnRight;
            @TurnRight.canceled -= instance.OnTurnRight;
            @TurnLeft.started -= instance.OnTurnLeft;
            @TurnLeft.performed -= instance.OnTurnLeft;
            @TurnLeft.canceled -= instance.OnTurnLeft;
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_MovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MovementActions @Movement => new MovementActions(this);
    public interface IWeaponActions
    {
        void OnRaiseScope(InputAction.CallbackContext context);
        void OnEnablePointerLine(InputAction.CallbackContext context);
        void OnIncreaseShotPower(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
    public interface IMovementActions
    {
        void OnHighJump(InputAction.CallbackContext context);
        void OnLongJump(InputAction.CallbackContext context);
        void OnDontMove(InputAction.CallbackContext context);
        void OnTurnRight(InputAction.CallbackContext context);
        void OnTurnLeft(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
}
