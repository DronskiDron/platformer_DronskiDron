using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Player
{
    public class PlayerControllerLegacy : MonoBehaviour
    {
        [SerializeField] private float _speed = 5f;

        private float _xDirection;
        private float _yDirection;


        private void Update()
        {
            PlayerHorizontalMover();
            PlayerVerticalMover();
        }


        public void SetDirectionX(float xDirection)
        {
            _xDirection = xDirection;
        }

        public void SetDirectionY(float yDirection)
        {
            _yDirection = yDirection;
        }


        public void SaySomething()
        {
            Debug.Log("ПАЛУНДРА!!!");
        }


        private void PlayerHorizontalMover()
        {
            if (_xDirection != 0)
            {
                var delta = _xDirection * _speed * Time.deltaTime;
                var newXPosition = transform.position.x + delta;
                transform.position = new Vector3(newXPosition, transform.position.y, transform.position.z);
            }
        }


        private void PlayerVerticalMover()
        {
            if (_yDirection != 0)
            {
                var delta = _yDirection * _speed * Time.deltaTime;
                var newYPosition = transform.position.y + delta;
                transform.position = new Vector3(transform.position.x, newYPosition, transform.position.z);
            }
        }
    }
}
