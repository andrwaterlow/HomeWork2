using UnityEngine;

namespace Assets.Scripts
{
    interface IViewServices
    {
        public void Create(GameObject prefab);
        public void Destroy(GameObject prefab);

    }
}
