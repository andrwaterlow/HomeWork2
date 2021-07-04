using UnityEngine;

namespace Assets.Scripts
{
    interface IShoot
    {

        float Forse { get; }
        void FlyBullet(GameObject prefab);
        void CreateBullet(GameObject prefab);
        void DestroyBullet(GameObject prefab);

    }
}

