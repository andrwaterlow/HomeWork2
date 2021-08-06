namespace Assets.Scripts
{
    interface IAbility
    {
        string Name { get; }
        int Damage { get; }
        Target Target { get; }
        DamageType DamageType { get; }
    }
}
