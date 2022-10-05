using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class PlayerInputReaderModernVersionSecond : MonoBehaviour
    {
        [SerializeField] private PlayerControllerModernVersion _player;
        
        private void OnTotalMovement(InputValue context)
        {
            var direction = context.Get<Vector2>();

            _player.SetDirection(direction);

        }


        private void OnSayingSomething(InputValue context)
        {
            _player.SaySomething();
        }
    }
}

