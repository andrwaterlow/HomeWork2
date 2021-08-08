using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    class CreateEnemy
    {
        IEnemyFactory factory = new AsteroidFactory();
        private EnemyLog _enemyLog = new EnemyLog();

        public void CreateOneEnemy()
        { 
            var health = new Health(100f, 100f, Delivery.getReference());
            var enemy = factory.Create(health);
            enemy.accept(_enemyLog);
            enemy.Init();
        }

        public void CreateFiveEnemies()
        {
            var health = new Health(100f, 100f, Delivery.getReference());
            var enemy = factory.Create(health);
            enemy.CreateFourAsteroids(health, factory);
        }
    }
}
