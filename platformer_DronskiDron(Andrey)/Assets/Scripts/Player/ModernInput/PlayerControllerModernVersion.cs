using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerControllerModernVersion : MonoBehaviour
    {
        [SerializeField] private float _speed = 5f;

        private float _defaultXDirection = 0;
        private float _defaultYDirection = 0;


        private void Update()
        {
            PlayerMover();
        }


        public void SetDirectionX(float xDirection)
        {
            _defaultXDirection = xDirection;
        }


        public void SetDirectionY(float yDirection)
        {
            _defaultYDirection = yDirection;
        }


        public void SaySomething()
        {
            Debug.Log("ПАЛУНДРА!!!");
        }


        private void PlayerMover()
        {
            {
                var deltaX = _defaultXDirection * _speed * Time.deltaTime;
                var deltaY = _defaultYDirection * _speed * Time.deltaTime;
                var newXPosition = transform.position.x + deltaX;
                var newYPosition = transform.position.y + deltaY;
                transform.position = new Vector3(newXPosition, newYPosition, transform.position.z);
            }
        }

    }
}

