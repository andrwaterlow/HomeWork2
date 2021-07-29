using System;
using UnityEngine;

namespace Assets.Scripts
{
    [Serializable]
    class SuperBullet : DecoratorFire
    {
        IShoot bullet;
        private float _force;
        public float damage = 150;
        
        public SuperBullet(IShoot bullet)
        {
            this.bullet = bullet;
            _force = Forse*2;
        }

        public override void CreateBullet(GameObject prefab)
        {  
            bullet.CreateBullet(prefab);
            bullet.CreateBullet(prefab);
        }

        public override void DestroyBullet(GameObject prefab)
        {
            bullet.DestroyBullet(prefab);
        }

        public override void FlyBullet(GameObject prefab)
        {   
            prefab.transform.Translate(prefab.transform.forward * Forse * Time.deltaTime);
        }
    }
}
