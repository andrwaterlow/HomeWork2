namespace Assets.Scripts
{
    public sealed class HighDamageIsOn
    {
        public bool highDamage { get; set; }

        public void UnlockHigeDamage(bool damageOn)
        {
            highDamage = damageOn;
        }
    }
}
