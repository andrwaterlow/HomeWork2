using System;

namespace Assets.Scripts
{
    [Serializable]
    class Messenger : Observer
    {
        Random randomNumberOfAsteroid = new Random();
        DateTime currentTime = DateTime.Now;
        TakeDamage TakeDamage;
        SafeMessenges SafeMessenges;
        public string LastMessege = String.Empty;

        public Messenger(TakeDamage takeDamage, SafeMessenges safeMessenges)
        {
            this.TakeDamage = takeDamage;
            TakeDamage.registerObserver(this);
            this.SafeMessenges = safeMessenges;
        }

        public string update()
        {
            string message = $"В {currentTime} был сбит неизвестный объект под секретным кодом {randomNumberOfAsteroid.Next(0, 1000000)}";
            LastMessege = message;
            SafeMessenges.saveMessege(message);
            return message;
        }
    }
}
