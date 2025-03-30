//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.13.1
//     from Assets/Code/Player/PlayerControl.inputactions
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

/// <summary>
/// Provides programmatic access to <see cref="InputActionAsset" />, <see cref="InputActionMap" />, <see cref="InputAction" /> and <see cref="InputControlScheme" /> instances defined in asset "Assets/Code/Player/PlayerControl.inputactions".
/// </summary>
/// <remarks>
/// This class is source generated and any manual edits will be discarded if the associated asset is reimported or modified.
/// </remarks>
/// <example>
/// <code>
/// using namespace UnityEngine;
/// using UnityEngine.InputSystem;
///
/// // Example of using an InputActionMap named "Player" from a UnityEngine.MonoBehaviour implementing callback interface.
/// public class Example : MonoBehaviour, MyActions.IPlayerActions
/// {
///     private MyActions_Actions m_Actions;                  // Source code representation of asset.
///     private MyActions_Actions.PlayerActions m_Player;     // Source code representation of action map.
///
///     void Awake()
///     {
///         m_Actions = new MyActions_Actions();              // Create asset object.
///         m_Player = m_Actions.Player;                      // Extract action map object.
///         m_Player.AddCallbacks(this);                      // Register callback interface IPlayerActions.
///     }
///
///     void OnDestroy()
///     {
///         m_Actions.Dispose();                              // Destroy asset object.
///     }
///
///     void OnEnable()
///     {
///         m_Player.Enable();                                // Enable all actions within map.
///     }
///
///     void OnDisable()
///     {
///         m_Player.Disable();                               // Disable all actions within map.
///     }
///
///     #region Interface implementation of MyActions.IPlayerActions
///
///     // Invoked when "Move" action is either started, performed or canceled.
///     public void OnMove(InputAction.CallbackContext context)
///     {
///         Debug.Log($"OnMove: {context.ReadValue&lt;Vector2&gt;()}");
///     }
///
///     // Invoked when "Attack" action is either started, performed or canceled.
///     public void OnAttack(InputAction.CallbackContext context)
///     {
///         Debug.Log($"OnAttack: {context.ReadValue&lt;float&gt;()}");
///     }
///
///     #endregion
/// }
/// </code>
/// </example>
public partial class @PlayerControl: IInputActionCollection2, IDisposable
{
    /// <summary>
    /// Provides access to the underlying asset instance.
    /// </summary>
    public InputActionAsset asset { get; }

    /// <summary>
    /// Constructs a new instance.
    /// </summary>
    public @PlayerControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControl"",
    ""maps"": [
        {
            ""name"": ""PlayerMoveInputs"",
            ""id"": ""896dbf6d-598e-4d3f-9711-305e29f0adc0"",
            ""actions"": [
                {
                    ""name"": ""PlayerMoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""7c43a02a-afb8-4984-965d-59c915fd0c16"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PlayerMoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""bd7116ff-7a3f-4aeb-b82a-fa6dee931676"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PlayerMoveUp"",
                    ""type"": ""Button"",
                    ""id"": ""cfbc82ac-96be-4417-b246-159a4ce3d383"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PlayerMoveDown"",
                    ""type"": ""Button"",
                    ""id"": ""5eac641c-6233-4c90-9401-030d6edbeda3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5e5f8f94-b8e5-42ce-83ca-86c2b8b4262a"",
                    ""path"": ""<HID::Bensussen Deutsch & Associates,Inc.(BDA) Core (Plus) Wired Controller>/hat/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da14ec02-f983-4582-a70e-1a72d048b4bf"",
                    ""path"": ""<HID::Bensussen Deutsch & Associates,Inc.(BDA) Core (Plus) Wired Controller>/hat/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""67941663-83b0-40db-9cc8-dd89b27157e6"",
                    ""path"": ""<HID::Bensussen Deutsch & Associates,Inc.(BDA) Core (Plus) Wired Controller>/hat/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cdb911af-1e32-41b1-8631-8200a7e1e198"",
                    ""path"": ""<HID::Bensussen Deutsch & Associates,Inc.(BDA) Core (Plus) Wired Controller>/hat/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMoveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerSoundSearch"",
            ""id"": ""273c8f99-92d2-4db5-8f24-d1a8696d31ac"",
            ""actions"": [
                {
                    ""name"": ""CheckLeft"",
                    ""type"": ""Button"",
                    ""id"": ""75a44a3a-d786-490e-8004-a8d5e84d514c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CheckRight"",
                    ""type"": ""Button"",
                    ""id"": ""1fb74563-3977-41d3-9453-ddbbe286b1c9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CheckFront"",
                    ""type"": ""Button"",
                    ""id"": ""6754ae11-f241-46df-96d7-7f264e0250b1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CheckBehind"",
                    ""type"": ""Button"",
                    ""id"": ""e78711eb-b435-48cf-a454-bbb9ef46d03e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""802fec1f-199f-4493-a04a-593476ddb972"",
                    ""path"": ""<HID::Bensussen Deutsch & Associates,Inc.(BDA) Core (Plus) Wired Controller>/button7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CheckLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef62b362-5bc0-4eba-b696-049b4f8c3def"",
                    ""path"": ""<HID::Bensussen Deutsch & Associates,Inc.(BDA) Core (Plus) Wired Controller>/button8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CheckRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a1243f5-351d-4fda-99a7-43a4c33716ab"",
                    ""path"": ""<HID::Bensussen Deutsch & Associates,Inc.(BDA) Core (Plus) Wired Controller>/button4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CheckFront"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3de7cf53-8d13-427e-a409-ac14af8cc23b"",
                    ""path"": ""<HID::Bensussen Deutsch & Associates,Inc.(BDA) Core (Plus) Wired Controller>/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CheckBehind"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerMoveInputs
        m_PlayerMoveInputs = asset.FindActionMap("PlayerMoveInputs", throwIfNotFound: true);
        m_PlayerMoveInputs_PlayerMoveLeft = m_PlayerMoveInputs.FindAction("PlayerMoveLeft", throwIfNotFound: true);
        m_PlayerMoveInputs_PlayerMoveRight = m_PlayerMoveInputs.FindAction("PlayerMoveRight", throwIfNotFound: true);
        m_PlayerMoveInputs_PlayerMoveUp = m_PlayerMoveInputs.FindAction("PlayerMoveUp", throwIfNotFound: true);
        m_PlayerMoveInputs_PlayerMoveDown = m_PlayerMoveInputs.FindAction("PlayerMoveDown", throwIfNotFound: true);
        // PlayerSoundSearch
        m_PlayerSoundSearch = asset.FindActionMap("PlayerSoundSearch", throwIfNotFound: true);
        m_PlayerSoundSearch_CheckLeft = m_PlayerSoundSearch.FindAction("CheckLeft", throwIfNotFound: true);
        m_PlayerSoundSearch_CheckRight = m_PlayerSoundSearch.FindAction("CheckRight", throwIfNotFound: true);
        m_PlayerSoundSearch_CheckFront = m_PlayerSoundSearch.FindAction("CheckFront", throwIfNotFound: true);
        m_PlayerSoundSearch_CheckBehind = m_PlayerSoundSearch.FindAction("CheckBehind", throwIfNotFound: true);
    }

    ~@PlayerControl()
    {
        UnityEngine.Debug.Assert(!m_PlayerMoveInputs.enabled, "This will cause a leak and performance issues, PlayerControl.PlayerMoveInputs.Disable() has not been called.");
        UnityEngine.Debug.Assert(!m_PlayerSoundSearch.enabled, "This will cause a leak and performance issues, PlayerControl.PlayerSoundSearch.Disable() has not been called.");
    }

    /// <summary>
    /// Destroys this asset and all associated <see cref="InputAction"/> instances.
    /// </summary>
    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindingMask" />
    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.devices" />
    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.controlSchemes" />
    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Contains(InputAction)" />
    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.GetEnumerator()" />
    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    /// <inheritdoc cref="IEnumerable.GetEnumerator()" />
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Enable()" />
    public void Enable()
    {
        asset.Enable();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Disable()" />
    public void Disable()
    {
        asset.Disable();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindings" />
    public IEnumerable<InputBinding> bindings => asset.bindings;

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindAction(string, bool)" />
    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindBinding(InputBinding, out InputAction)" />
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerMoveInputs
    private readonly InputActionMap m_PlayerMoveInputs;
    private List<IPlayerMoveInputsActions> m_PlayerMoveInputsActionsCallbackInterfaces = new List<IPlayerMoveInputsActions>();
    private readonly InputAction m_PlayerMoveInputs_PlayerMoveLeft;
    private readonly InputAction m_PlayerMoveInputs_PlayerMoveRight;
    private readonly InputAction m_PlayerMoveInputs_PlayerMoveUp;
    private readonly InputAction m_PlayerMoveInputs_PlayerMoveDown;
    /// <summary>
    /// Provides access to input actions defined in input action map "PlayerMoveInputs".
    /// </summary>
    public struct PlayerMoveInputsActions
    {
        private @PlayerControl m_Wrapper;

        /// <summary>
        /// Construct a new instance of the input action map wrapper class.
        /// </summary>
        public PlayerMoveInputsActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        /// <summary>
        /// Provides access to the underlying input action "PlayerMoveInputs/PlayerMoveLeft".
        /// </summary>
        public InputAction @PlayerMoveLeft => m_Wrapper.m_PlayerMoveInputs_PlayerMoveLeft;
        /// <summary>
        /// Provides access to the underlying input action "PlayerMoveInputs/PlayerMoveRight".
        /// </summary>
        public InputAction @PlayerMoveRight => m_Wrapper.m_PlayerMoveInputs_PlayerMoveRight;
        /// <summary>
        /// Provides access to the underlying input action "PlayerMoveInputs/PlayerMoveUp".
        /// </summary>
        public InputAction @PlayerMoveUp => m_Wrapper.m_PlayerMoveInputs_PlayerMoveUp;
        /// <summary>
        /// Provides access to the underlying input action "PlayerMoveInputs/PlayerMoveDown".
        /// </summary>
        public InputAction @PlayerMoveDown => m_Wrapper.m_PlayerMoveInputs_PlayerMoveDown;
        /// <summary>
        /// Provides access to the underlying input action map instance.
        /// </summary>
        public InputActionMap Get() { return m_Wrapper.m_PlayerMoveInputs; }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Enable()" />
        public void Enable() { Get().Enable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Disable()" />
        public void Disable() { Get().Disable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.enabled" />
        public bool enabled => Get().enabled;
        /// <summary>
        /// Implicitly converts an <see ref="PlayerMoveInputsActions" /> to an <see ref="InputActionMap" /> instance.
        /// </summary>
        public static implicit operator InputActionMap(PlayerMoveInputsActions set) { return set.Get(); }
        /// <summary>
        /// Adds <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <param name="instance">Callback instance.</param>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c> or <paramref name="instance"/> have already been added this method does nothing.
        /// </remarks>
        /// <seealso cref="PlayerMoveInputsActions" />
        public void AddCallbacks(IPlayerMoveInputsActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerMoveInputsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerMoveInputsActionsCallbackInterfaces.Add(instance);
            @PlayerMoveLeft.started += instance.OnPlayerMoveLeft;
            @PlayerMoveLeft.performed += instance.OnPlayerMoveLeft;
            @PlayerMoveLeft.canceled += instance.OnPlayerMoveLeft;
            @PlayerMoveRight.started += instance.OnPlayerMoveRight;
            @PlayerMoveRight.performed += instance.OnPlayerMoveRight;
            @PlayerMoveRight.canceled += instance.OnPlayerMoveRight;
            @PlayerMoveUp.started += instance.OnPlayerMoveUp;
            @PlayerMoveUp.performed += instance.OnPlayerMoveUp;
            @PlayerMoveUp.canceled += instance.OnPlayerMoveUp;
            @PlayerMoveDown.started += instance.OnPlayerMoveDown;
            @PlayerMoveDown.performed += instance.OnPlayerMoveDown;
            @PlayerMoveDown.canceled += instance.OnPlayerMoveDown;
        }

        /// <summary>
        /// Removes <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <remarks>
        /// Calling this method when <paramref name="instance" /> have not previously been registered has no side-effects.
        /// </remarks>
        /// <seealso cref="PlayerMoveInputsActions" />
        private void UnregisterCallbacks(IPlayerMoveInputsActions instance)
        {
            @PlayerMoveLeft.started -= instance.OnPlayerMoveLeft;
            @PlayerMoveLeft.performed -= instance.OnPlayerMoveLeft;
            @PlayerMoveLeft.canceled -= instance.OnPlayerMoveLeft;
            @PlayerMoveRight.started -= instance.OnPlayerMoveRight;
            @PlayerMoveRight.performed -= instance.OnPlayerMoveRight;
            @PlayerMoveRight.canceled -= instance.OnPlayerMoveRight;
            @PlayerMoveUp.started -= instance.OnPlayerMoveUp;
            @PlayerMoveUp.performed -= instance.OnPlayerMoveUp;
            @PlayerMoveUp.canceled -= instance.OnPlayerMoveUp;
            @PlayerMoveDown.started -= instance.OnPlayerMoveDown;
            @PlayerMoveDown.performed -= instance.OnPlayerMoveDown;
            @PlayerMoveDown.canceled -= instance.OnPlayerMoveDown;
        }

        /// <summary>
        /// Unregisters <param cref="instance" /> and unregisters all input action callbacks via <see cref="PlayerMoveInputsActions.UnregisterCallbacks(IPlayerMoveInputsActions)" />.
        /// </summary>
        /// <seealso cref="PlayerMoveInputsActions.UnregisterCallbacks(IPlayerMoveInputsActions)" />
        public void RemoveCallbacks(IPlayerMoveInputsActions instance)
        {
            if (m_Wrapper.m_PlayerMoveInputsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        /// <summary>
        /// Replaces all existing callback instances and previously registered input action callbacks associated with them with callbacks provided via <param cref="instance" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c>, calling this method will only unregister all existing callbacks but not register any new callbacks.
        /// </remarks>
        /// <seealso cref="PlayerMoveInputsActions.AddCallbacks(IPlayerMoveInputsActions)" />
        /// <seealso cref="PlayerMoveInputsActions.RemoveCallbacks(IPlayerMoveInputsActions)" />
        /// <seealso cref="PlayerMoveInputsActions.UnregisterCallbacks(IPlayerMoveInputsActions)" />
        public void SetCallbacks(IPlayerMoveInputsActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerMoveInputsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerMoveInputsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    /// <summary>
    /// Provides a new <see cref="PlayerMoveInputsActions" /> instance referencing this action map.
    /// </summary>
    public PlayerMoveInputsActions @PlayerMoveInputs => new PlayerMoveInputsActions(this);

    // PlayerSoundSearch
    private readonly InputActionMap m_PlayerSoundSearch;
    private List<IPlayerSoundSearchActions> m_PlayerSoundSearchActionsCallbackInterfaces = new List<IPlayerSoundSearchActions>();
    private readonly InputAction m_PlayerSoundSearch_CheckLeft;
    private readonly InputAction m_PlayerSoundSearch_CheckRight;
    private readonly InputAction m_PlayerSoundSearch_CheckFront;
    private readonly InputAction m_PlayerSoundSearch_CheckBehind;
    /// <summary>
    /// Provides access to input actions defined in input action map "PlayerSoundSearch".
    /// </summary>
    public struct PlayerSoundSearchActions
    {
        private @PlayerControl m_Wrapper;

        /// <summary>
        /// Construct a new instance of the input action map wrapper class.
        /// </summary>
        public PlayerSoundSearchActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        /// <summary>
        /// Provides access to the underlying input action "PlayerSoundSearch/CheckLeft".
        /// </summary>
        public InputAction @CheckLeft => m_Wrapper.m_PlayerSoundSearch_CheckLeft;
        /// <summary>
        /// Provides access to the underlying input action "PlayerSoundSearch/CheckRight".
        /// </summary>
        public InputAction @CheckRight => m_Wrapper.m_PlayerSoundSearch_CheckRight;
        /// <summary>
        /// Provides access to the underlying input action "PlayerSoundSearch/CheckFront".
        /// </summary>
        public InputAction @CheckFront => m_Wrapper.m_PlayerSoundSearch_CheckFront;
        /// <summary>
        /// Provides access to the underlying input action "PlayerSoundSearch/CheckBehind".
        /// </summary>
        public InputAction @CheckBehind => m_Wrapper.m_PlayerSoundSearch_CheckBehind;
        /// <summary>
        /// Provides access to the underlying input action map instance.
        /// </summary>
        public InputActionMap Get() { return m_Wrapper.m_PlayerSoundSearch; }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Enable()" />
        public void Enable() { Get().Enable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Disable()" />
        public void Disable() { Get().Disable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.enabled" />
        public bool enabled => Get().enabled;
        /// <summary>
        /// Implicitly converts an <see ref="PlayerSoundSearchActions" /> to an <see ref="InputActionMap" /> instance.
        /// </summary>
        public static implicit operator InputActionMap(PlayerSoundSearchActions set) { return set.Get(); }
        /// <summary>
        /// Adds <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <param name="instance">Callback instance.</param>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c> or <paramref name="instance"/> have already been added this method does nothing.
        /// </remarks>
        /// <seealso cref="PlayerSoundSearchActions" />
        public void AddCallbacks(IPlayerSoundSearchActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerSoundSearchActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerSoundSearchActionsCallbackInterfaces.Add(instance);
            @CheckLeft.started += instance.OnCheckLeft;
            @CheckLeft.performed += instance.OnCheckLeft;
            @CheckLeft.canceled += instance.OnCheckLeft;
            @CheckRight.started += instance.OnCheckRight;
            @CheckRight.performed += instance.OnCheckRight;
            @CheckRight.canceled += instance.OnCheckRight;
            @CheckFront.started += instance.OnCheckFront;
            @CheckFront.performed += instance.OnCheckFront;
            @CheckFront.canceled += instance.OnCheckFront;
            @CheckBehind.started += instance.OnCheckBehind;
            @CheckBehind.performed += instance.OnCheckBehind;
            @CheckBehind.canceled += instance.OnCheckBehind;
        }

        /// <summary>
        /// Removes <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <remarks>
        /// Calling this method when <paramref name="instance" /> have not previously been registered has no side-effects.
        /// </remarks>
        /// <seealso cref="PlayerSoundSearchActions" />
        private void UnregisterCallbacks(IPlayerSoundSearchActions instance)
        {
            @CheckLeft.started -= instance.OnCheckLeft;
            @CheckLeft.performed -= instance.OnCheckLeft;
            @CheckLeft.canceled -= instance.OnCheckLeft;
            @CheckRight.started -= instance.OnCheckRight;
            @CheckRight.performed -= instance.OnCheckRight;
            @CheckRight.canceled -= instance.OnCheckRight;
            @CheckFront.started -= instance.OnCheckFront;
            @CheckFront.performed -= instance.OnCheckFront;
            @CheckFront.canceled -= instance.OnCheckFront;
            @CheckBehind.started -= instance.OnCheckBehind;
            @CheckBehind.performed -= instance.OnCheckBehind;
            @CheckBehind.canceled -= instance.OnCheckBehind;
        }

        /// <summary>
        /// Unregisters <param cref="instance" /> and unregisters all input action callbacks via <see cref="PlayerSoundSearchActions.UnregisterCallbacks(IPlayerSoundSearchActions)" />.
        /// </summary>
        /// <seealso cref="PlayerSoundSearchActions.UnregisterCallbacks(IPlayerSoundSearchActions)" />
        public void RemoveCallbacks(IPlayerSoundSearchActions instance)
        {
            if (m_Wrapper.m_PlayerSoundSearchActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        /// <summary>
        /// Replaces all existing callback instances and previously registered input action callbacks associated with them with callbacks provided via <param cref="instance" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c>, calling this method will only unregister all existing callbacks but not register any new callbacks.
        /// </remarks>
        /// <seealso cref="PlayerSoundSearchActions.AddCallbacks(IPlayerSoundSearchActions)" />
        /// <seealso cref="PlayerSoundSearchActions.RemoveCallbacks(IPlayerSoundSearchActions)" />
        /// <seealso cref="PlayerSoundSearchActions.UnregisterCallbacks(IPlayerSoundSearchActions)" />
        public void SetCallbacks(IPlayerSoundSearchActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerSoundSearchActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerSoundSearchActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    /// <summary>
    /// Provides a new <see cref="PlayerSoundSearchActions" /> instance referencing this action map.
    /// </summary>
    public PlayerSoundSearchActions @PlayerSoundSearch => new PlayerSoundSearchActions(this);
    /// <summary>
    /// Interface to implement callback methods for all input action callbacks associated with input actions defined by "PlayerMoveInputs" which allows adding and removing callbacks.
    /// </summary>
    /// <seealso cref="PlayerMoveInputsActions.AddCallbacks(IPlayerMoveInputsActions)" />
    /// <seealso cref="PlayerMoveInputsActions.RemoveCallbacks(IPlayerMoveInputsActions)" />
    public interface IPlayerMoveInputsActions
    {
        /// <summary>
        /// Method invoked when associated input action "PlayerMoveLeft" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnPlayerMoveLeft(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "PlayerMoveRight" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnPlayerMoveRight(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "PlayerMoveUp" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnPlayerMoveUp(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "PlayerMoveDown" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnPlayerMoveDown(InputAction.CallbackContext context);
    }
    /// <summary>
    /// Interface to implement callback methods for all input action callbacks associated with input actions defined by "PlayerSoundSearch" which allows adding and removing callbacks.
    /// </summary>
    /// <seealso cref="PlayerSoundSearchActions.AddCallbacks(IPlayerSoundSearchActions)" />
    /// <seealso cref="PlayerSoundSearchActions.RemoveCallbacks(IPlayerSoundSearchActions)" />
    public interface IPlayerSoundSearchActions
    {
        /// <summary>
        /// Method invoked when associated input action "CheckLeft" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnCheckLeft(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "CheckRight" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnCheckRight(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "CheckFront" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnCheckFront(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "CheckBehind" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnCheckBehind(InputAction.CallbackContext context);
    }
}
