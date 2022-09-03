// GENERATED AUTOMATICALLY FROM 'Assets/12.Input_Test/Player_Test_Input.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Player_Test_Input : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player_Test_Input()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player_Test_Input"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""4b0c7bd6-6638-4011-9cbc-62ddebb873dc"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""371e43a5-6f09-4480-94cb-09a9f8aeae9f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WSAD"",
                    ""id"": ""296d345e-cc20-4a38-a30e-3b35a331d965"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6cef6480-5c1b-4eb6-9252-07daa50e8cfe"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""37f896c9-c8b4-465e-b441-4e2de8c6a8c2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""06c9a54f-b918-46fd-9b73-3f039c2edc77"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8b45b8f6-ae9d-448e-a262-e7b7e7f21a97"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""0eefe8b6-e17e-4168-9b52-c4a43f53e99d"",
            ""actions"": [
                {
                    ""name"": ""ItemDrop"",
                    ""type"": ""Button"",
                    ""id"": ""9197ee4f-c088-4095-8c9f-df06c3ba6fa4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ed3a93a1-1241-4146-b392-c560fc45a4bd"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""ItemDrop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ShortCut"",
            ""id"": ""8a75062a-cb54-4885-b9c1-b6da3f37c3f5"",
            ""actions"": [
                {
                    ""name"": ""InventoryOnOff"",
                    ""type"": ""Button"",
                    ""id"": ""2b485883-8f4e-4f75-bbef-121ecf722e62"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ad53a4c7-f78e-4458-a27b-0b4005cdc7b6"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""InventoryOnOff"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""K&M"",
            ""bindingGroup"": ""K&M"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_ItemDrop = m_UI.FindAction("ItemDrop", throwIfNotFound: true);
        // ShortCut
        m_ShortCut = asset.FindActionMap("ShortCut", throwIfNotFound: true);
        m_ShortCut_InventoryOnOff = m_ShortCut.FindAction("InventoryOnOff", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    public struct PlayerActions
    {
        private @Player_Test_Input m_Wrapper;
        public PlayerActions(@Player_Test_Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_ItemDrop;
    public struct UIActions
    {
        private @Player_Test_Input m_Wrapper;
        public UIActions(@Player_Test_Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @ItemDrop => m_Wrapper.m_UI_ItemDrop;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @ItemDrop.started -= m_Wrapper.m_UIActionsCallbackInterface.OnItemDrop;
                @ItemDrop.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnItemDrop;
                @ItemDrop.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnItemDrop;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ItemDrop.started += instance.OnItemDrop;
                @ItemDrop.performed += instance.OnItemDrop;
                @ItemDrop.canceled += instance.OnItemDrop;
            }
        }
    }
    public UIActions @UI => new UIActions(this);

    // ShortCut
    private readonly InputActionMap m_ShortCut;
    private IShortCutActions m_ShortCutActionsCallbackInterface;
    private readonly InputAction m_ShortCut_InventoryOnOff;
    public struct ShortCutActions
    {
        private @Player_Test_Input m_Wrapper;
        public ShortCutActions(@Player_Test_Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @InventoryOnOff => m_Wrapper.m_ShortCut_InventoryOnOff;
        public InputActionMap Get() { return m_Wrapper.m_ShortCut; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShortCutActions set) { return set.Get(); }
        public void SetCallbacks(IShortCutActions instance)
        {
            if (m_Wrapper.m_ShortCutActionsCallbackInterface != null)
            {
                @InventoryOnOff.started -= m_Wrapper.m_ShortCutActionsCallbackInterface.OnInventoryOnOff;
                @InventoryOnOff.performed -= m_Wrapper.m_ShortCutActionsCallbackInterface.OnInventoryOnOff;
                @InventoryOnOff.canceled -= m_Wrapper.m_ShortCutActionsCallbackInterface.OnInventoryOnOff;
            }
            m_Wrapper.m_ShortCutActionsCallbackInterface = instance;
            if (instance != null)
            {
                @InventoryOnOff.started += instance.OnInventoryOnOff;
                @InventoryOnOff.performed += instance.OnInventoryOnOff;
                @InventoryOnOff.canceled += instance.OnInventoryOnOff;
            }
        }
    }
    public ShortCutActions @ShortCut => new ShortCutActions(this);
    private int m_KMSchemeIndex = -1;
    public InputControlScheme KMScheme
    {
        get
        {
            if (m_KMSchemeIndex == -1) m_KMSchemeIndex = asset.FindControlSchemeIndex("K&M");
            return asset.controlSchemes[m_KMSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnItemDrop(InputAction.CallbackContext context);
    }
    public interface IShortCutActions
    {
        void OnInventoryOnOff(InputAction.CallbackContext context);
    }
}
