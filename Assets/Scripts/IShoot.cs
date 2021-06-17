using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

interface IShoot
{

    float Forse { get; }
    void FlyBullet(Rigidbody bullet );

}

