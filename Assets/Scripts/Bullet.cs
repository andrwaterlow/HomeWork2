using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class Bullet : IShoot
{

   public float Forse { get; protected set; }

    

    public Bullet(float force)
    {
        Forse = force;
    }

    public void FlyBullet(Rigidbody bullet)
    {
        bullet.AddForce(bullet.transform.forward * Forse, ForceMode.Impulse);
    }
}

