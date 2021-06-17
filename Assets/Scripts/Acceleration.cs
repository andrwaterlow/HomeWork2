using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class Acceleration : Move
    {
        private readonly float _acceleration;

        public Acceleration(Rigidbody ship, float speed, float acceleration) : base(ship, speed)
        {
            _acceleration = acceleration;
        }

        public void AddAcceleration()
        {
            Speed += _acceleration;
        }

        public void RemoveAcceleration()
        {
            Speed -= _acceleration;
        }

    }

