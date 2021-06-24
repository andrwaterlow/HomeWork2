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
  

    
    public bool DeatOrLive( float currentHP)
    {
        if (currentHP <= 0)
        {
            IsAlive = false;
        }
        else
        {
            IsAlive = true;
        }
        return IsAlive;
    }

    public  void MakeDamage(float currentHP, int damage , bool IsAlive)
    {
        if (IsAlive)
        {
            currentHP -= damage;
        }
        
    }

}

