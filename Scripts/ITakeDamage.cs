using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

interface ITakeDamage
{       
        GameObject GameObject { get; }
        
    
        void MakeDamage(float currentHP, int damage, bool IsAlive);
    
}

