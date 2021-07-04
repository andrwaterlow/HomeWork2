using UnityEngine;

namespace Assets.Scripts
{
    class Acceleration : Move
    {
        private readonly float _acceleration;

        public Acceleration(Rigidbody ship, float speed, float acceleration) : base(ship, speed)
        {
            _acceleration = acceleration;
        }

        public void AddAcceleration(bool dawnbutton)
        {
            if (dawnbutton)
            {
                Speed += _acceleration;
            }

        }

        public void RemoveAcceleration(bool dawnbutton)
        {
            if (!dawnbutton)
            {
                Speed -= _acceleration;
            }

        }

    }
}

