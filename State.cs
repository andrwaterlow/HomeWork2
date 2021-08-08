using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    abstract class State : IMove
    {
        protected Rigidbody Rigidbody;
        public float Speed { get; protected set; }

        public State(Rigidbody rigidbody, float speed)
        {
            this.Rigidbody = rigidbody;
            this.Speed = speed;
        }

        public abstract void Movement(Rigidbody ship, float vertical, float horizontal, float deltaTime); 
    }
}
