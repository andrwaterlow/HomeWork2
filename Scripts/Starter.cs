using System;
using UnityEngine;

namespace Assets.Scripts
{
    [Serializable] internal sealed class Starter : MonoBehaviour
    {

        private void Start()
        {


            IEnemyFactory factory = new AsteroidFactory();
            var health = new Health(100f, 100f);
            var enemy = factory.Create(health);
            enemy.CreateFiveAsteroids(health, factory);



        }
    }
}



