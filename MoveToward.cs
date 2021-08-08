using UnityEngine;

namespace Assets.Scripts
{
    class MoveToward : State
    {
        public MoveToward(Rigidbody rigidbody, float speed) : base(rigidbody, speed) { }

        public override void Movement(Rigidbody ship, float vertical, float horizontal, float deltaTime)
        {
            var speed = deltaTime * Speed;
            ship.AddForce(Vector3.back * speed, ForceMode.Force);
        }
    }
}
