using UnityEngine;

namespace Assets.Scripts
{
    interface ITakeDamage
    {
        GameObject GameObject { get; }
        void MakeDamage(float currentHP, int damage);
    }
}

