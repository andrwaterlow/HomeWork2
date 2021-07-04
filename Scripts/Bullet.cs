using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    internal class Bullet : IShoot
    {

        public float Forse { get; protected set; }
        public GameObject Object { get; protected set; }

        private ViewServices _viewServices;
        private ChangeBullets _changeBullets;

        public Bullet(float force)
        {
            Forse = force;
            _viewServices = new ViewServices();
            _changeBullets = new ChangeBullets();
            _changeBullets.InitServicePoolObject();
            _changeBullets.InitServiceViewServices();
        }

        public void FlyBullet(GameObject prefab)
        { 
            var bullet = prefab.GetComponent<Rigidbody>();
            bullet.AddForce(bullet.transform.forward * Forse, ForceMode.Impulse);
        }

        public void CreateBullet(GameObject prefab)
        {
           _viewServices.Create(prefab);
            /*  FlyBullet(prefab);*/
        }

        public void DestroyBullet(GameObject prefab)
        {
            _viewServices.Destroy(prefab);
        }

        public Stack<GameObject> GetStackBullets()
        {     
            var bulletsStack = _changeBullets.GetPool();
            return bulletsStack;
        }
    }
}

