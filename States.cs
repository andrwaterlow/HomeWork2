using UnityEngine;

namespace Assets.Scripts
{
    public sealed class States : IMove
    {
        private Rigidbody _rigidbody;
        private Enter _enter;
        private State _moveLeft;
        private State _moveRight;
        private State _moveForward;
        private State _moveToward;
        private State _moveNothing;

        private int _currentState = 0;
        private int _forward = 1;
        private int _toward = 2;
        private int _left = 3;
        private int _right = 4;
        private int _nothing = 0;
        public float Speed { get; set; }

        internal States(Rigidbody rigidbody, float speed, Enter enter)
        {
            this._rigidbody = rigidbody;
            this.Speed = speed;
            this._enter = enter;
            InitStates();
        }

        private void InitStates()
        {
            _moveLeft = new MoveToLeft(_rigidbody, Speed);
            _moveRight = new MoveToRight(_rigidbody, Speed);
            _moveForward = new MoveForward(_rigidbody, Speed);
            _moveToward = new MoveToward(_rigidbody, Speed);
            _moveNothing = new MoveNothing(_rigidbody, Speed);
        }

        public void Movement(Rigidbody ship, float vertical, float horizontal, float deltaTime)
        {
            changeState();
            moveForward();
            moveToward();
            moveToLeft();
            moveToRight();
            moveNothing();
        }

        private void changeState()
        {
            _currentState = _enter.getNumberOfState();
        }

        private void moveForward()
        {
            if (_currentState == _forward)
                _moveForward.Movement(_rigidbody, 0f, 0f, Time.deltaTime);
        }

        private void moveToward()
        {
            if (_currentState == _toward)
                _moveToward.Movement(_rigidbody, 0f, 0f, Time.deltaTime);
        }

        private void moveToLeft()
        {
            if (_currentState == _left)
                _moveLeft.Movement(_rigidbody, 0f, 0f, Time.deltaTime);
        }

        private void moveToRight()
        {
            if (_currentState == _right)
                _moveRight.Movement(_rigidbody, 0f, 0f, Time.deltaTime);
        }

        private void moveNothing()
        {
            if (_currentState == _nothing)
                _moveNothing.Movement(_rigidbody, 0f, 0f, Time.deltaTime);
        }
    }
}
