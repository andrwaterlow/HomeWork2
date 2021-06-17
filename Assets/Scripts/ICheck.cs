using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

interface ICheck
{
    bool IsAlive { get; }
    void DeatOrLive( float currentHP);
}

