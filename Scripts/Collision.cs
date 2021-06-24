using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    class Collision : MonoBehaviour
    {
        private Bullet bullet;

        
        public void OnCollisionEnter(UnityEngine.Collision collision)
        {

            bullet.DestroyBullet(bullet.Object);

            
        }
    }
}
