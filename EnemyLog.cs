using System;

namespace Assets.Scripts
{
    internal class EnemyLog : IVisitor
    {
        DateTime currentTime = DateTime.Now;
        SafeMessenges SafeMessenges;
        public string LastMessege = String.Empty;

        public EnemyLog()
        {
            this.SafeMessenges = Delivery.getReference();
        }

        public virtual void Make(Asteroids enemy)
        {
            string message = $"В {currentTime} был замечен враг!";
            LastMessege = message;
            SafeMessenges.saveMessege(message);
        }
    }
}
