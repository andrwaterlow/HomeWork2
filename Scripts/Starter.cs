using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal sealed class Starter : MonoBehaviour
{
   
    private void Start()
    {
       

        IEnemyFactory factory = new AsteroidFactory();

        factory.Create(new Health(100.0f, 100.0f)).Init();

       
        
    }
}



