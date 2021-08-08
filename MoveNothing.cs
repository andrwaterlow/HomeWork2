using UnityEngine;

namespace Assets.Scripts
{
    internal sealed class MoveNothing : State 
    {
        public MoveNothing(Rigidbody rigidbody, float speed) : base(rigidbody, speed) { }

        public override void Movement(Rigidbody ship, float vertical, float horizontal, float deltaTime)
        {
            var speed = deltaTime * Speed;
            ship.AddForce(Vector3.zero, ForceMode.Force);
        }
    }
}
