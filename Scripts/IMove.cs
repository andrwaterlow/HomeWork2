using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

interface IMove
    {
         float Speed { get; }
         void Movement(Rigidbody ship, float vertical, float horizontal, float deltaTime);
    }

