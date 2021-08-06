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

        public void CreateOneEnemy()
        { 
            var health = new Health(100f, 100f);
            var enemy = factory.Create(health); 
        }

        public void CreateFiveEnemies()
        {
            var health = new Health(100f, 100f);
            var enemy = factory.Create(health);
            enemy.CreateFourAsteroids(health, factory);
        }
    }
}
