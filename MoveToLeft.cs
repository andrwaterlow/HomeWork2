using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    internal sealed class MoveToLeft : State
    {
        public MoveToLeft(Rigidbody rigidbody, float speed) : base(rigidbody, speed) { }

        public override void Movement(Rigidbody ship, float vertical, float horizontal, float deltaTime)
        {
            var speed = deltaTime * Speed;
            ship.AddForce(Vector3.left * speed, ForceMode.Force);
        }
    }
}
