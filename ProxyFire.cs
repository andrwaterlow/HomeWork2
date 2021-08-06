using System;
using UnityEngine;

namespace Assets.Scripts
{
    [Serializable]
    internal sealed class ProxyFire
    {
        IShoot fier;
        IShoot superFire;

        HighDamageIsOn highDamageIsOn;
        GameObject _bullet = (GameObject) Resources.Load("Bullets");

        public ProxyFire(IShoot fire,  HighDamageIsOn highDamageIsOn, float force)
        {
            superFire = new Bullet(force);
            superFire = new SuperBullet(superFire);
            this.fier = fire;
            this.highDamageIsOn = highDamageIsOn;
        }

        public void Fire()
        {
            if (highDamageIsOn.highDamage)
            {
                superFire.CreateBullet(_bullet);
            }
            if (!highDamageIsOn.highDamage)
            {
                fier.CreateBullet(_bullet);
            }
        }
    }
}
