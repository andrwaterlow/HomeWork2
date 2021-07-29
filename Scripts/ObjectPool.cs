using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    internal sealed class ObjectPool : IPoolObject
    {
        public Stack<GameObject>_stack { get; set; } = new Stack<GameObject>();
        private readonly GameObject _prefab;

        public ObjectPool(GameObject prefab)
        {
            _prefab = prefab;
        }

        public void Push(GameObject go)
        {
            _stack.Push(go);
            go.SetActive(false);
        }

        public GameObject Pop()
        {
            GameObject go;
            if (_stack.Count == 0)
            {
                go = Object.Instantiate(_prefab);
            }
            else
            {
                go = _stack.Pop();
            }
            go.SetActive(true);
            return go;
        }
    }
}

