using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    interface IViewServices
    {
        public Dictionary<int, ObjectPool> _viewCache { get; set; }
        public void Create(GameObject prefab);
        public void Destroy(GameObject prefab);
    }
}
