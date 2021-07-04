using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    class ChangeBullets 
    {
        GameObject gameObject = (GameObject)Resources.Load("Bullets");

        public void InitServicePoolObject()
        {
            ServiceLocator.SetService<IPoolObject>(new ObjectPool(gameObject));
        }

        public void InitServiceViewServices()
        {
            ServiceLocator.SetService<IViewServices>(new ViewServices());
        }

        public Stack<GameObject> GetPool ()
        {
           var stack = ServiceLocator.Resolve<IPoolObject>()._stack;
            return stack;
        }

        public void GetPop()
        {
            ServiceLocator.Resolve<IPoolObject>().Pop();
        }

        public void GetPush()
        {
            ServiceLocator.Resolve<IPoolObject>().Push(gameObject);
        }
    }
}
