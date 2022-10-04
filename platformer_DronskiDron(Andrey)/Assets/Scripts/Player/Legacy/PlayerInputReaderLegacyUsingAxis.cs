using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Player 
{
    public class PlayerInputReaderLegacyUsingAxis : MonoBehaviour
    {
        [SerializeField] private PlayerControllerLegacy _player;


        private void Update()
        {
            GetHorizontalMovingInput();

            GetVerticalMovingInput();

            GetSaySomethingInput();
        }


        private void GetHorizontalMovingInput()
        {
            var horizontalAxis = Input.GetAxis("Horizontal");
            _player.SetDirectionX(horizontalAxis);
        }


        private void GetVerticalMovingInput()
        {
            var verticalAxis = Input.GetAxis("Vertical");
            _player.SetDirectionY(verticalAxis);
        }


        private void GetSaySomethingInput()
        {
            if (Input.GetButtonUp("Fire1"))
            {
                _player.SaySomething();
            }
        }
    }
}

