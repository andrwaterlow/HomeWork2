using UnityEngine;

namespace Assets.Scripts
{
    internal class Collision : MonoBehaviour
    {
        private Bullet bullet;


        public void OnCollisionEnter(UnityEngine.Collision collision)
        {
            bullet.DestroyBullet(bullet.Object); 
        }
    }
}
