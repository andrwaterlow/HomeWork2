using UnityEngine;

namespace Assets.Scripts
{
    public  class Move : IMove
    {
        private readonly Rigidbody _ship;
        public float Speed { get; protected set; }
        private Vector3 _move;

        public Move(Rigidbody ship, float speed)
        {
            _ship = ship;
            Speed = speed;
        }

        public void Movement(Rigidbody ship, float vertical, float horizontal, float deltaTime)
        {
            var speed = deltaTime * Speed;
            ship.AddForce(horizontal * speed, vertical * speed, 0.0f, ForceMode.Force);
        }
    }
}
