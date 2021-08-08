namespace Assets.Scripts
{
    interface ICheck
    {
        bool IsAlive { get; }
        bool DeatOrLive(float currentHP);
    }
}

