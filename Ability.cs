namespace Assets.Scripts
{
    internal sealed class Ability : IAbility
    {
        public string Name { get; }
        public int Damage { get; }
        public Target Target { get; }
        public DamageType DamageType { get; }

        public Ability(string name, int damage, Target target, DamageType damageType)
        {
            this.Name = name;
            this.Damage = damage;
            this.Target = target;
            this.DamageType = DamageType;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
