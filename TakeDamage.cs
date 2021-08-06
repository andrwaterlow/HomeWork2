using UnityEngine;

namespace Assets.Scripts
{
    sealed class  TakeDamage : ITakeDamage, ICheck
    {
        public GameObject GameObject { get;  set; }
        public bool IsAlive { get;  set; }

        public bool DeatOrLive(float currentHP)
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

        public void MakeDamage(float currentHP, int damage, bool IsAlive)
        {
            if (IsAlive)
            {
                currentHP -= damage;
            }
        }
    }
}

