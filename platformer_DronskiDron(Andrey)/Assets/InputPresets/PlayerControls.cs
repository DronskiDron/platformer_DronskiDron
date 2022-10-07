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
                    ""name"": ""SayingSomething"",
                    ""type"": ""Button"",
                    ""id"": ""ba0de3df-3c7d-497e-a1c5-535239a9bb4c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TotalMovement"",
                    ""type"": ""Value"",
                    ""id"": ""19238ce7-8d1f-48e9-aa15-4638695be253"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jumping"",
                    ""type"": ""Value"",
                    ""id"": ""29a5fff7-5c4a-4f47-9240-df965896d8fc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
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
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""c87c25f3-65f7-4638-aea6-033e8c5a94e8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TotalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2ff5bea6-1b14-4ea9-a7a1-fa31f9dd7009"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TotalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1a0e24b5-857e-4f37-8c9d-fb21db63d894"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TotalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7ec70776-8334-4d0d-9837-fd068fc6ff95"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TotalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0f0b0af0-0295-4372-bf46-051817ebcc38"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TotalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""1b198e7b-ca80-429b-a220-dae07454ea0f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jumping"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1e6996da-5ee2-449f-98ef-6d28ce352470"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jumping"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // PlayerActionMap
            m_PlayerActionMap = asset.FindActionMap("PlayerActionMap", throwIfNotFound: true);
            m_PlayerActionMap_SayingSomething = m_PlayerActionMap.FindAction("SayingSomething", throwIfNotFound: true);
            m_PlayerActionMap_TotalMovement = m_PlayerActionMap.FindAction("TotalMovement", throwIfNotFound: true);
            m_PlayerActionMap_Jumping = m_PlayerActionMap.FindAction("Jumping", throwIfNotFound: true);
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
        private readonly InputAction m_PlayerActionMap_SayingSomething;
        private readonly InputAction m_PlayerActionMap_TotalMovement;
        private readonly InputAction m_PlayerActionMap_Jumping;
        public struct PlayerActionMapActions
        {
            private @PlayerControls m_Wrapper;
            public PlayerActionMapActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @SayingSomething => m_Wrapper.m_PlayerActionMap_SayingSomething;
            public InputAction @TotalMovement => m_Wrapper.m_PlayerActionMap_TotalMovement;
            public InputAction @Jumping => m_Wrapper.m_PlayerActionMap_Jumping;
            public InputActionMap Get() { return m_Wrapper.m_PlayerActionMap; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerActionMapActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerActionMapActions instance)
            {
                if (m_Wrapper.m_PlayerActionMapActionsCallbackInterface != null)
                {
                    @SayingSomething.started -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnSayingSomething;
                    @SayingSomething.performed -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnSayingSomething;
                    @SayingSomething.canceled -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnSayingSomething;
                    @TotalMovement.started -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnTotalMovement;
                    @TotalMovement.performed -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnTotalMovement;
                    @TotalMovement.canceled -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnTotalMovement;
                    @Jumping.started -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnJumping;
                    @Jumping.performed -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnJumping;
                    @Jumping.canceled -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnJumping;
                }
                m_Wrapper.m_PlayerActionMapActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @SayingSomething.started += instance.OnSayingSomething;
                    @SayingSomething.performed += instance.OnSayingSomething;
                    @SayingSomething.canceled += instance.OnSayingSomething;
                    @TotalMovement.started += instance.OnTotalMovement;
                    @TotalMovement.performed += instance.OnTotalMovement;
                    @TotalMovement.canceled += instance.OnTotalMovement;
                    @Jumping.started += instance.OnJumping;
                    @Jumping.performed += instance.OnJumping;
                    @Jumping.canceled += instance.OnJumping;
                }
            }
        }
        public PlayerActionMapActions @PlayerActionMap => new PlayerActionMapActions(this);
        public interface IPlayerActionMapActions
        {
            void OnSayingSomething(InputAction.CallbackContext context);
            void OnTotalMovement(InputAction.CallbackContext context);
            void OnJumping(InputAction.CallbackContext context);
        }
    }
}
