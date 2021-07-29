using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
