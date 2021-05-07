// GENERATED AUTOMATICALLY FROM 'Assets/ProjectAgileJet/ImportantFiles/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace ProjectAgileJet.Input
{
    public class @PlayerInput : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerInput()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Game"",
            ""id"": ""e936ea74-a096-463e-9467-5a63a415e4b1"",
            ""actions"": [
                {
                    ""name"": ""Pitch"",
                    ""type"": ""Value"",
                    ""id"": ""3f1be00d-2eaf-4533-aac6-752bd076b68c"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""Value"",
                    ""id"": ""a91dceb2-a8e9-48f6-afef-5f46686b0e1f"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Yaw"",
                    ""type"": ""Button"",
                    ""id"": ""343d9db9-9f13-4fbd-9740-6aa0679ab1ae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Boost"",
                    ""type"": ""Button"",
                    ""id"": ""724c6a62-1eaf-4cef-ba60-ea11e38e7c1a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FadMode"",
                    ""type"": ""Button"",
                    ""id"": ""c9a0286e-4a63-468b-a481-097bb7c9627d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FadLook"",
                    ""type"": ""Value"",
                    ""id"": ""3d8ab492-652b-4c8c-9748-08304e78063f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""46061489-4e60-498a-ad3d-c82758175467"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""12dd1767-45c3-4ac5-98fc-d2489e3e9b95"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4aa8fbb2-0e4e-4786-b5ad-ee97ce5533dc"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a5b203a0-9146-49ee-b6e8-48036de2cfc9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""acf036bf-9009-4787-8290-659618dc581b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5c87345d-5765-463f-bccf-f69310431fcf"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5a5fe5f8-04fe-43f2-9d5a-ee73e374368b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8c8ec91d-b92d-4baf-8d8d-a0653853f395"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""0c703e85-da35-4641-8c50-9b61bc05ca9a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yaw"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5ce7a21a-eca5-4a89-a231-1094ea75f254"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""09b5b55f-1b52-4741-9663-912fd647a5f3"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d61743f9-1f10-4e35-ba27-609a403d8f2e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FadMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dab79ea8-77b1-4853-af5d-df0058249c77"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FadLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cca41a1c-0197-4ddd-bd18-afe03ec3af08"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""fabcc365-8ab0-420d-8648-1d1314cb8b4f"",
            ""actions"": [
                {
                    ""name"": ""LeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""cd64622e-c08e-4894-ad67-3bed8696d761"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""ea40a0e8-b8f7-4d52-9e0b-98eec22ec7e2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""e13c8414-c9b6-463e-ab21-7a9587688680"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Value"",
                    ""id"": ""21e1af61-0fa0-40ce-b244-778c33cab7b2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""Value"",
                    ""id"": ""67c43c0c-a520-4f45-b5ce-8fa7f7964c05"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScrollWheel"",
                    ""type"": ""Value"",
                    ""id"": ""6ecc501b-4f2c-4d4e-af5b-28f22b75b049"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Return"",
                    ""type"": ""Button"",
                    ""id"": ""e27e34e0-2f00-47e6-993a-d9ade3355cd3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""05ddfef4-d95a-4dbd-a74a-3e217c06b018"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""44c48ecc-4850-4628-8f09-d99b1ca6f259"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""645942c1-9ed4-46a2-b660-c1a0eda9a8a5"",
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
                    ""id"": ""92ae6f6c-c885-41e5-a66d-840c0bdbbbb8"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2688dec5-1b55-4f3a-ab0f-a70b20b2a23d"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1c491f05-80d1-4494-8848-749fb83bbc69"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""77a03421-59dd-4e75-bf3a-b02d343ecc19"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""dabafe6e-58c5-43b7-9b56-3cd5ad1d81cb"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a817c329-4df1-445b-a9f7-8343d897dc2c"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b1e3d7d-65ea-40db-9eb1-b3ea3414c13d"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2240d4f1-e57c-421e-a52a-d40e1af049ac"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ScrollWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""abe6fed6-d4e8-4ce3-a1cb-32c860b73cdc"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Return"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7fed8807-2fc9-49ad-967e-b048dcb5b8df"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e41253e0-9d9c-49f6-aa2e-6d8eff619292"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Game
            m_Game = asset.FindActionMap("Game", throwIfNotFound: true);
            m_Game_Pitch = m_Game.FindAction("Pitch", throwIfNotFound: true);
            m_Game_Roll = m_Game.FindAction("Roll", throwIfNotFound: true);
            m_Game_Yaw = m_Game.FindAction("Yaw", throwIfNotFound: true);
            m_Game_Boost = m_Game.FindAction("Boost", throwIfNotFound: true);
            m_Game_FadMode = m_Game.FindAction("FadMode", throwIfNotFound: true);
            m_Game_FadLook = m_Game.FindAction("FadLook", throwIfNotFound: true);
            m_Game_Fire = m_Game.FindAction("Fire", throwIfNotFound: true);
            // Menu
            m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
            m_Menu_LeftClick = m_Menu.FindAction("LeftClick", throwIfNotFound: true);
            m_Menu_Move = m_Menu.FindAction("Move", throwIfNotFound: true);
            m_Menu_Submit = m_Menu.FindAction("Submit", throwIfNotFound: true);
            m_Menu_Cancel = m_Menu.FindAction("Cancel", throwIfNotFound: true);
            m_Menu_Point = m_Menu.FindAction("Point", throwIfNotFound: true);
            m_Menu_ScrollWheel = m_Menu.FindAction("ScrollWheel", throwIfNotFound: true);
            m_Menu_Return = m_Menu.FindAction("Return", throwIfNotFound: true);
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

        // Game
        private readonly InputActionMap m_Game;
        private IGameActions m_GameActionsCallbackInterface;
        private readonly InputAction m_Game_Pitch;
        private readonly InputAction m_Game_Roll;
        private readonly InputAction m_Game_Yaw;
        private readonly InputAction m_Game_Boost;
        private readonly InputAction m_Game_FadMode;
        private readonly InputAction m_Game_FadLook;
        private readonly InputAction m_Game_Fire;
        public struct GameActions
        {
            private @PlayerInput m_Wrapper;
            public GameActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Pitch => m_Wrapper.m_Game_Pitch;
            public InputAction @Roll => m_Wrapper.m_Game_Roll;
            public InputAction @Yaw => m_Wrapper.m_Game_Yaw;
            public InputAction @Boost => m_Wrapper.m_Game_Boost;
            public InputAction @FadMode => m_Wrapper.m_Game_FadMode;
            public InputAction @FadLook => m_Wrapper.m_Game_FadLook;
            public InputAction @Fire => m_Wrapper.m_Game_Fire;
            public InputActionMap Get() { return m_Wrapper.m_Game; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GameActions set) { return set.Get(); }
            public void SetCallbacks(IGameActions instance)
            {
                if (m_Wrapper.m_GameActionsCallbackInterface != null)
                {
                    @Pitch.started -= m_Wrapper.m_GameActionsCallbackInterface.OnPitch;
                    @Pitch.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnPitch;
                    @Pitch.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnPitch;
                    @Roll.started -= m_Wrapper.m_GameActionsCallbackInterface.OnRoll;
                    @Roll.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnRoll;
                    @Roll.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnRoll;
                    @Yaw.started -= m_Wrapper.m_GameActionsCallbackInterface.OnYaw;
                    @Yaw.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnYaw;
                    @Yaw.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnYaw;
                    @Boost.started -= m_Wrapper.m_GameActionsCallbackInterface.OnBoost;
                    @Boost.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnBoost;
                    @Boost.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnBoost;
                    @FadMode.started -= m_Wrapper.m_GameActionsCallbackInterface.OnFadMode;
                    @FadMode.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnFadMode;
                    @FadMode.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnFadMode;
                    @FadLook.started -= m_Wrapper.m_GameActionsCallbackInterface.OnFadLook;
                    @FadLook.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnFadLook;
                    @FadLook.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnFadLook;
                    @Fire.started -= m_Wrapper.m_GameActionsCallbackInterface.OnFire;
                    @Fire.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnFire;
                    @Fire.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnFire;
                }
                m_Wrapper.m_GameActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Pitch.started += instance.OnPitch;
                    @Pitch.performed += instance.OnPitch;
                    @Pitch.canceled += instance.OnPitch;
                    @Roll.started += instance.OnRoll;
                    @Roll.performed += instance.OnRoll;
                    @Roll.canceled += instance.OnRoll;
                    @Yaw.started += instance.OnYaw;
                    @Yaw.performed += instance.OnYaw;
                    @Yaw.canceled += instance.OnYaw;
                    @Boost.started += instance.OnBoost;
                    @Boost.performed += instance.OnBoost;
                    @Boost.canceled += instance.OnBoost;
                    @FadMode.started += instance.OnFadMode;
                    @FadMode.performed += instance.OnFadMode;
                    @FadMode.canceled += instance.OnFadMode;
                    @FadLook.started += instance.OnFadLook;
                    @FadLook.performed += instance.OnFadLook;
                    @FadLook.canceled += instance.OnFadLook;
                    @Fire.started += instance.OnFire;
                    @Fire.performed += instance.OnFire;
                    @Fire.canceled += instance.OnFire;
                }
            }
        }
        public GameActions @Game => new GameActions(this);

        // Menu
        private readonly InputActionMap m_Menu;
        private IMenuActions m_MenuActionsCallbackInterface;
        private readonly InputAction m_Menu_LeftClick;
        private readonly InputAction m_Menu_Move;
        private readonly InputAction m_Menu_Submit;
        private readonly InputAction m_Menu_Cancel;
        private readonly InputAction m_Menu_Point;
        private readonly InputAction m_Menu_ScrollWheel;
        private readonly InputAction m_Menu_Return;
        public struct MenuActions
        {
            private @PlayerInput m_Wrapper;
            public MenuActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @LeftClick => m_Wrapper.m_Menu_LeftClick;
            public InputAction @Move => m_Wrapper.m_Menu_Move;
            public InputAction @Submit => m_Wrapper.m_Menu_Submit;
            public InputAction @Cancel => m_Wrapper.m_Menu_Cancel;
            public InputAction @Point => m_Wrapper.m_Menu_Point;
            public InputAction @ScrollWheel => m_Wrapper.m_Menu_ScrollWheel;
            public InputAction @Return => m_Wrapper.m_Menu_Return;
            public InputActionMap Get() { return m_Wrapper.m_Menu; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
            public void SetCallbacks(IMenuActions instance)
            {
                if (m_Wrapper.m_MenuActionsCallbackInterface != null)
                {
                    @LeftClick.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnLeftClick;
                    @LeftClick.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnLeftClick;
                    @LeftClick.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnLeftClick;
                    @Move.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnMove;
                    @Submit.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnSubmit;
                    @Submit.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnSubmit;
                    @Submit.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnSubmit;
                    @Cancel.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnCancel;
                    @Cancel.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnCancel;
                    @Cancel.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnCancel;
                    @Point.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnPoint;
                    @Point.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnPoint;
                    @Point.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnPoint;
                    @ScrollWheel.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnScrollWheel;
                    @ScrollWheel.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnScrollWheel;
                    @ScrollWheel.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnScrollWheel;
                    @Return.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnReturn;
                    @Return.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnReturn;
                    @Return.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnReturn;
                }
                m_Wrapper.m_MenuActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @LeftClick.started += instance.OnLeftClick;
                    @LeftClick.performed += instance.OnLeftClick;
                    @LeftClick.canceled += instance.OnLeftClick;
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @Submit.started += instance.OnSubmit;
                    @Submit.performed += instance.OnSubmit;
                    @Submit.canceled += instance.OnSubmit;
                    @Cancel.started += instance.OnCancel;
                    @Cancel.performed += instance.OnCancel;
                    @Cancel.canceled += instance.OnCancel;
                    @Point.started += instance.OnPoint;
                    @Point.performed += instance.OnPoint;
                    @Point.canceled += instance.OnPoint;
                    @ScrollWheel.started += instance.OnScrollWheel;
                    @ScrollWheel.performed += instance.OnScrollWheel;
                    @ScrollWheel.canceled += instance.OnScrollWheel;
                    @Return.started += instance.OnReturn;
                    @Return.performed += instance.OnReturn;
                    @Return.canceled += instance.OnReturn;
                }
            }
        }
        public MenuActions @Menu => new MenuActions(this);
        public interface IGameActions
        {
            void OnPitch(InputAction.CallbackContext context);
            void OnRoll(InputAction.CallbackContext context);
            void OnYaw(InputAction.CallbackContext context);
            void OnBoost(InputAction.CallbackContext context);
            void OnFadMode(InputAction.CallbackContext context);
            void OnFadLook(InputAction.CallbackContext context);
            void OnFire(InputAction.CallbackContext context);
        }
        public interface IMenuActions
        {
            void OnLeftClick(InputAction.CallbackContext context);
            void OnMove(InputAction.CallbackContext context);
            void OnSubmit(InputAction.CallbackContext context);
            void OnCancel(InputAction.CallbackContext context);
            void OnPoint(InputAction.CallbackContext context);
            void OnScrollWheel(InputAction.CallbackContext context);
            void OnReturn(InputAction.CallbackContext context);
        }
    }
}
