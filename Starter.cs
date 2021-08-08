using System;
using UnityEngine;

namespace Assets.Scripts 
{ 
    internal sealed class Starter : MonoBehaviour 
    {
        CreateEnemy CreateEnemy = new CreateEnemy();

        private void Start()
        {
            CreateEnemy.CreateOneEnemy();
            CreateEnemy.CreateOneEnemy();
            CreateEnemy.CreateOneEnemy();
            CreateEnemy.CreateOneEnemy();
            CreateEnemy.CreateOneEnemy();
            /*CreateEnemy.CreateFiveEnemies();*/
        }
    }
}



