using System;
using UnityEngine;

namespace Assets.Scripts // �������� �����
{ 
    [Serializable] internal sealed class Starter : MonoBehaviour 
    {
        CreateEnemy CreateEnemy = new CreateEnemy();

        private void Start()
        {
            CreateEnemy.CreateOneEnemy();
            CreateEnemy.CreateFiveEnemies();
        }
    }
}



