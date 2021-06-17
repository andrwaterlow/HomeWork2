using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


class TakeDamage : ITakeDamage, ICheck
{

    public GameObject GameObject { get; protected set; }
    public bool IsAlive { get; protected set; }
  

    
    public void DeatOrLive( float currentHP)
    {
        if (currentHP <= 0)
        {
            IsAlive = false;
        }
        else
        {
            IsAlive = true;
        }
    }

    public  void MakeDamage(float currentHP, int damage)
    {
        currentHP -= damage;
    }

}

