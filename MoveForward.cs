using UnityEngine;

namespace Assets.Scripts
{
    internal sealed class MoveForward : State
    {
        public MoveForward(Rigidbody rigidbody, float speed) : base(rigidbody, speed) { }

        public override void Movement(Rigidbody ship, float vertical, float horizontal, float deltaTime)
        {
            var speed = deltaTime * Speed;
            ship.AddForce(Vector3.forward * speed, ForceMode.Force);
        }
    }
}
