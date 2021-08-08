using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    class BulletTrible : IShoot
    {
        public float Forse { get; protected set; }
        private float _speedOfBullet = 15;

        public BulletTrible(float force)
        {
            Forse = force;  
        }

        public void FlyBullet(GameObject prefab)
        { 
            prefab.transform.Translate(prefab.transform.forward*_speedOfBullet*Time.deltaTime);
        }

        public void CreateBullet(GameObject prefab)
        {
            prefab.Create();
            prefab.Create();
            prefab.Create();
        }

        public void DestroyBullet(GameObject prefab)
        {
            prefab.Destroy();
        }
    }
}
