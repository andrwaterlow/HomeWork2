using UnityEngine;

namespace Assets.Scripts
{
    class AccelerationSuper : MoveFaster 
    {
        private readonly float _acceleration;

        public AccelerationSuper(Rigidbody ship, float speed, float acceleration) : base(ship, speed)
        {
            _acceleration = acceleration;
        }

        public void AddAcceleration(bool dawnbutton)
        {
            if (dawnbutton)
            {
                Speed += _acceleration*2;
            }
        }

        public void RemoveAcceleration(bool dawnbutton)
        {
            if (!dawnbutton)
            {
                Speed -= _acceleration*2;
            }
        }
    }
}
