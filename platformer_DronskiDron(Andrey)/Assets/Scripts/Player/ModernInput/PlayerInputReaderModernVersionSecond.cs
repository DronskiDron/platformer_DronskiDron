using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class PlayerInputReaderModernVersionSecond : MonoBehaviour
    {
        [SerializeField] private PlayerControllerModernVersion _player;
        
        private void OnHorizontalMovement(InputValue context)
        {
            var xDirection = context.Get<float>();

            _player.SetDirectionX(xDirection);

        }


        private void OnVerticalMovement(InputValue context)
        {
            var yDirection = context.Get<float>();

            _player.SetDirectionY(yDirection);

        }

        private void OnSayingSomething(InputValue context)
        {
            _player.SaySomething();
        }
    }
}

