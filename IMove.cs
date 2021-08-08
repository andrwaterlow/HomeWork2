using UnityEngine;

namespace Assets.Scripts
{
    interface IMove
    {
        float Speed { get; }
        void Movement(Rigidbody ship, float vertical, float horizontal, float deltaTime);
    }
}

