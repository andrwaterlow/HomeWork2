using System;

namespace Assets.Scripts
{
    [Serializable]
    internal sealed class Health : IHealth
    {
        public float Max { get; }
        public float Current { get; private set; }

        public bool IsAlive { get; private set; } = true;
        public TakeDamage TakeDamage { get; set; }
        public Messenger Messenger { get; set; }
        SafeMessenges SafeMessenges;

        public Health(float max, float current, SafeMessenges safeMessenges)
        {
            Max = max;
            Current = current;
            TakeDamage = new TakeDamage();
            Messenger = new Messenger(TakeDamage, safeMessenges);
            this.SafeMessenges = safeMessenges;
        }

        public void ChangeCurrentHealth(float hp)
        {
            Current = hp;
        }
    }
}



