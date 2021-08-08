using UnityEngine;

namespace Assets.Scripts
{
    class MoveFaster : IMove
    {
        private readonly Rigidbody _ship;
        public float Speed { get; protected set; }
        
        public MoveFaster(Rigidbody ship, float speed)
        {
            _ship = ship;
            Speed = speed;
        }

        public void Movement(Rigidbody ship, float vertical, float horizontal, float deltaTime)
        {
            var speed = deltaTime*Speed*2;
            ship.AddForce(horizontal*speed, vertical*speed, 0.0f, ForceMode.Impulse);
        }
    }
}
