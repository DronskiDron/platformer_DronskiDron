using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class PlayerInputReaderModernVersionTheThird : MonoBehaviour
    {
        [SerializeField] private PlayerControllerModernVersion _player;

        private PlayerControls _inputActions;


        private void Awake()
        {
            _inputActions = new PlayerControls();

            _inputActions.PlayerActionMap.HorizontalMovement.performed += OnHorizontalMovement;
            _inputActions.PlayerActionMap.HorizontalMovement.canceled += OnHorizontalMovement;

            _inputActions.PlayerActionMap.VerticalMovement.performed += OnVerticalMovement;
            _inputActions.PlayerActionMap.VerticalMovement.canceled += OnVerticalMovement;

            _inputActions.PlayerActionMap.SayingSomething.performed += OnSayingSomething;
        }


        private void OnEnable()
        {
            _inputActions.Enable();
        }


        private void OnHorizontalMovement(InputAction.CallbackContext context)
        {
            var xDirection = context.ReadValue<float>();

            _player.SetDirectionX(xDirection);

        }


        private void OnVerticalMovement(InputAction.CallbackContext context)
        {
            var yDirection = context.ReadValue<float>();

            _player.SetDirectionY(yDirection);

        }

        private void OnSayingSomething(InputAction.CallbackContext context)
        {
            _player.SaySomething();
        }
    }
}

