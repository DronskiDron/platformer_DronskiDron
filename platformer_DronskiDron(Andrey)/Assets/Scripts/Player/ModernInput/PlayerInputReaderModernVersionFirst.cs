﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class PlayerInputReaderModernVersionFirst : MonoBehaviour
    {
        [SerializeField] private PlayerControllerModernVersion _player;


        public void OnHorizontalMovementGetInput(InputAction.CallbackContext context)
        {
            var xDirection = context.ReadValue<float>();

            _player.SetDirectionX (xDirection);

        }


        public void OnVerticalMovementGetInput(InputAction.CallbackContext context)
        {
            var yDirection = context.ReadValue<float>();

            _player.SetDirectionY( yDirection);

        }

        public void OnSaySomethingGetInput(InputAction.CallbackContext context)
        {
            if (context.canceled)
            {
                _player.SaySomething();
            }
           
        }
    }

}
