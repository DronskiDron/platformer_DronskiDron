﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class PlayerInputReader : MonoBehaviour
    {
        [SerializeField] private PlayerController _player;
        [SerializeField] private PlayerJumpChecker _playerJumpChecker;


        private void OnTotalMovement(InputValue context)
        {
            var direction = context.Get<Vector2>();

            _player.SetMoveDirection(direction);
        }

        private void OnJumping(InputValue context)
        {
            var jumpVector = context.Get<Vector2>();
            _playerJumpChecker.SetIsJumping(jumpVector);
        }


        private void OnSayingSomething(InputValue context)
        {
            _player.SaySomething();
        }
    }
}

