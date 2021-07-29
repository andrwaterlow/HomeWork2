using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    abstract class DecoratorFire : IShoot
    {
        public float Forse => 200;

        abstract public void CreateBullet(GameObject prefab);

        abstract public void DestroyBullet(GameObject prefab);

        abstract public void FlyBullet(GameObject prefab);
        
    }
}
