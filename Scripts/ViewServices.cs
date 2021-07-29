using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    [Serializable]
    internal sealed class ViewServices : IViewServices
    {
        public Dictionary<int, ObjectPool> _viewCache { get; set; } = new Dictionary<int, ObjectPool>();
        
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

