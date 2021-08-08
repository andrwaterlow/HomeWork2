using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    internal sealed class Asteroids : Enemy
    {
        int MaxAsteroids = 4;
        public Health Health { get; private set; }
        private int _damage = 50;

        GameObject Asteroid;

        public Asteroids(Health health)
        {
            Health = health;
        }

        public GameObject Init()
        {
            Asteroid = (GameObject)GameObject.Instantiate(Resources.Load("Asteroid"));
            return Asteroid;
        }

        public void CreateFourAsteroids(Health health, IEnemyFactory factory)
        {
            for (int i = 0; i < MaxAsteroids; i++)
            {
                var healthclone = health.DeepCopy();
                factory.Create(healthclone).Init();  
            }
        }

        public void TakeDamage()
        {
            Health.TakeDamage.MakeDamage(Health.Current, _damage);
        }

        public override void accept(IVisitor visitor)
        {
            visitor.Make(this);
        }
    }
}

