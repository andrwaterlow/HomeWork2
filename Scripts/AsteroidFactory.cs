

using System;

namespace Assets.Scripts
{
    [Serializable]
    internal class AsteroidFactory : IEnemyFactory
    {

        public Asteroids Create(Health hp)
        {
            var enemy = new Asteroids(hp);

            return enemy;
        }
    }
}

