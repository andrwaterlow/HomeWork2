using System;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.Scripts
{
    [Serializable]
    internal class Bullet : IShoot
    {

        public float Forse { get; protected set; }
        public GameObject Object { get; protected set; }
        public float damage = 50;

        private ViewServices _viewServices;
        private BulletFunction _bulletFunction;

        public Bullet(float force)
        {
            Forse = force;
            _viewServices = new ViewServices();
            _bulletFunction = new BulletFunction();
            _bulletFunction.InitServicePoolObject();
            _bulletFunction.InitServiceViewServices();
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
            var bulletsStack = _bulletFunction.GetPool();
            return bulletsStack;
        }

        public Dictionary<int, ObjectPool> GetkeyDictionaryBullets()
        {
            var dictionary = _bulletFunction.keyValuePairsBullets();
            return dictionary;
        }
    }
}

