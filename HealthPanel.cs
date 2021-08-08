using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    internal sealed class HealthPanel : BaseUI
    {
        [SerializeField] private Text _text;

        public override void Execute()
        {
            _text.text = nameof(HealthPanel);
            gameObject.SetActive(true);
        }

        public override void Cancel()
        {
            gameObject.SetActive(false);
        }
    }
}
