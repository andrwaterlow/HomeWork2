using System;
using UnityEngine;

namespace Assets.Scripts
{
    internal abstract class Enemy 
    {
        public static IEnemyFactory Factory;

        public abstract void accept(IVisitor visitor); 
    }
}



