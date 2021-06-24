using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class Bullet : IShoot
{

   public float Forse { get; protected set; }
    public GameObject Object { get; protected set; }

    private ViewServices _viewServices;
    private ObjectPool ObjectPool;

    public Bullet(float force, GameObject prefab)
    {
        Forse = force;
        _viewServices = new ViewServices();
        ObjectPool = new ObjectPool(prefab);
    }

    public void FlyBullet(GameObject prefab)
    {
        var bullet = prefab.GetComponent<Rigidbody>();
        bullet.AddForce(bullet.transform.forward * Forse, ForceMode.Impulse);
    }

    public void CreateBullet (GameObject prefab)
    {
        _viewServices.Create(prefab);
      /*  FlyBullet(prefab);*/
    }

    public void DestroyBullet(GameObject prefab)
    {
        _viewServices.Destroy(prefab);
    }
}

