using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    internal sealed class ViewServices : IViewServices
    {

        private readonly Dictionary<int, ObjectPool> _viewCache = new Dictionary<int, ObjectPool>();

        public void Create(GameObject prefab)
        {
            if (!_viewCache.TryGetValue(prefab.GetInstanceID(), out ObjectPool viewPool))
            {
                viewPool = new ObjectPool(prefab);
                _viewCache[prefab.GetInstanceID()] = viewPool;
            }
            viewPool.Pop();
        }

        public void Destroy(GameObject prefab)
        {
            _viewCache[prefab.GetInstanceID()].Push(prefab);
        }

    }
}

