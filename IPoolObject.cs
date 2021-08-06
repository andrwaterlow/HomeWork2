using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    interface IPoolObject
    {
        public Stack<GameObject>_stack { get; set; } 
        public void Push(GameObject go);
        public GameObject Pop();
    }
}
