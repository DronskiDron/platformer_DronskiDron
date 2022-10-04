using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Player
{
    public class PlayerInputReaderLegacyUsingKeys : MonoBehaviour
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

            if (Input.GetKey(KeyCode.A))
            {
                _player.SetDirectionX( -1f);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                _player.SetDirectionX(1f);
            }
            else
            {
                _player.SetDirectionX(0);
            }
        }


        private void GetVerticalMovingInput()
        {

            
            if (Input.GetKey(KeyCode.W))
            {
                _player.SetDirectionY(1f);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                _player.SetDirectionY(-1f);
            }

            else
            {
                _player.SetDirectionY(0);
            }
        }


        private void GetSaySomethingInput()
        {
            if (Input.GetMouseButtonUp(0))
            {
                _player.SaySomething();
            }
        }
    }
}
