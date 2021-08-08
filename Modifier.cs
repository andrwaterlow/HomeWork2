namespace Assets.Scripts
{
    internal  class Modifier
    {
        protected Player Player;
        protected Modifier Next;

        public Modifier(Player Player)
        {
            this.Player = Player;
        }

        public void Add(Modifier modifier)
        {
            if (Next != null)
            {
                Next.Add(modifier);
            }
            else 
            {
                Next = modifier;
            }
        }

        public virtual void Handle() => Next.Handle();
    }
}
