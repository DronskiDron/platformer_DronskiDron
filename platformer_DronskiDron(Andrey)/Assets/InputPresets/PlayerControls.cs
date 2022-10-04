// GENERATED AUTOMATICALLY FROM 'Assets/InputPresets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Player
{
    public class @PlayerControls : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""PlayerActionMap"",
            ""id"": ""2d19ece9-75f1-493a-a8a9-82b71a39943b"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMovement"",
                    ""type"": ""Button"",
                    ""id"": ""3cedadbc-ba07-435a-a547-a5de03fff5c7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""VerticalMovement"",
                    ""type"": ""Button"",
                    ""id"": ""0ce30839-8571-47f9-9b42-7dc099d5a1e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SayingSomething"",
                    ""type"": ""Button"",
                    ""id"": ""ba0de3df-3c7d-497e-a1c5-535239a9bb4c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASDhorizontal"",
                    ""id"": ""8c61eaeb-97a3-4bc4-b3bc-c2a26754f620"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""51d5f06e-8f36-4a8a-b8e0-d15fe9305680"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""786a9999-5880-4444-b975-993f88007f62"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASDvertical"",
                    ""id"": ""1726a4a2-2be8-4b09-a7d7-d67c50bfcc95"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""625bdad8-08d4-437a-904f-9c60529c615c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""6db173c6-cf26-442a-97e5-ab3bf5e9559c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bfb9994c-8d17-4cac-b571-10370f6fff24"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SayingSomething"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // PlayerActionMap
            m_PlayerActionMap = asset.FindActionMap("PlayerActionMap", throwIfNotFound: true);
            m_PlayerActionMap_HorizontalMovement = m_PlayerActionMap.FindAction("HorizontalMovement", throwIfNotFound: true);
            m_PlayerActionMap_VerticalMovement = m_PlayerActionMap.FindAction("VerticalMovement", throwIfNotFound: true);
            m_PlayerActionMap_SayingSomething = m_PlayerActionMap.FindAction("SayingSomething", throwIfNotFound: true);
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

        // PlayerActionMap
        private readonly InputActionMap m_PlayerActionMap;
        private IPlayerActionMapActions m_PlayerActionMapActionsCallbackInterface;
        private readonly InputAction m_PlayerActionMap_HorizontalMovement;
        private readonly InputAction m_PlayerActionMap_VerticalMovement;
        private readonly InputAction m_PlayerActionMap_SayingSomething;
        public struct PlayerActionMapActions
        {
            private @PlayerControls m_Wrapper;
            public PlayerActionMapActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @HorizontalMovement => m_Wrapper.m_PlayerActionMap_HorizontalMovement;
            public InputAction @VerticalMovement => m_Wrapper.m_PlayerActionMap_VerticalMovement;
            public InputAction @SayingSomething => m_Wrapper.m_PlayerActionMap_SayingSomething;
            public InputActionMap Get() { return m_Wrapper.m_PlayerActionMap; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerActionMapActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerActionMapActions instance)
            {
                if (m_Wrapper.m_PlayerActionMapActionsCallbackInterface != null)
                {
                    @HorizontalMovement.started -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnHorizontalMovement;
                    @HorizontalMovement.performed -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnHorizontalMovement;
                    @HorizontalMovement.canceled -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnHorizontalMovement;
                    @VerticalMovement.started -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnVerticalMovement;
                    @VerticalMovement.performed -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnVerticalMovement;
                    @VerticalMovement.canceled -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnVerticalMovement;
                    @SayingSomething.started -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnSayingSomething;
                    @SayingSomething.performed -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnSayingSomething;
                    @SayingSomething.canceled -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnSayingSomething;
                }
                m_Wrapper.m_PlayerActionMapActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @HorizontalMovement.started += instance.OnHorizontalMovement;
                    @HorizontalMovement.performed += instance.OnHorizontalMovement;
                    @HorizontalMovement.canceled += instance.OnHorizontalMovement;
                    @VerticalMovement.started += instance.OnVerticalMovement;
                    @VerticalMovement.performed += instance.OnVerticalMovement;
                    @VerticalMovement.canceled += instance.OnVerticalMovement;
                    @SayingSomething.started += instance.OnSayingSomething;
                    @SayingSomething.performed += instance.OnSayingSomething;
                    @SayingSomething.canceled += instance.OnSayingSomething;
                }
            }
        }
        public PlayerActionMapActions @PlayerActionMap => new PlayerActionMapActions(this);
        public interface IPlayerActionMapActions
        {
            void OnHorizontalMovement(InputAction.CallbackContext context);
            void OnVerticalMovement(InputAction.CallbackContext context);
            void OnSayingSomething(InputAction.CallbackContext context);
        }
    }
}
