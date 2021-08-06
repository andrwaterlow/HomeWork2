using UnityEngine;

namespace Assets.Scripts
{
    internal abstract class BaseUI : MonoBehaviour
    {
        public abstract void Execute();
        public abstract void Cancel();
    }
}
