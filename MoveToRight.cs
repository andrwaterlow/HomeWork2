using UnityEngine;

namespace Assets.Scripts
{
    internal sealed class MoveToRight : State
    {
        public MoveToRight(Rigidbody rigidbody, float speed) : base(rigidbody, speed) { }

        public override void Movement(Rigidbody ship, float vertical, float horizontal, float deltaTime)
        {
            var speed = deltaTime * Speed;
            ship.AddForce(Vector3.right * speed, ForceMode.Force);
        }
    }
}
