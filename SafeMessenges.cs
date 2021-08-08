using System;
using System.Collections.Generic;

namespace Assets.Scripts
{
    [Serializable]
    public sealed class SafeMessenges
    {
        public List<string> Messeges = new List<string>();

        public void saveMessege(string messege)
        {
            Messeges.Add(messege);
        }
    }
}
