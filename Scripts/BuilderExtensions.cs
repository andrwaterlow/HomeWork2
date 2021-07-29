using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public static class BuilderExtensions
    {
        public static void Create(this GameObject gameObject)
        {
            ServiceLocator.Resolve<IViewServices>().Create(gameObject);
        }

        public static void Destroy(this GameObject gameObject)
        {
            ServiceLocator.Resolve<IViewServices>().Destroy(gameObject);
        }
    }
}
