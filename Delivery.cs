using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public sealed class Delivery
    {
        static SafeMessenges SafeMessenges = new SafeMessenges();

        public static SafeMessenges getReference()
        {
            return SafeMessenges;
        }
    }
}
