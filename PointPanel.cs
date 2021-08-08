using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    sealed internal class PointPanel : BaseUI
    {
        [SerializeField] private Text _text;

        public override void Execute()
        {
            _text.text = nameof(PointPanel);
            gameObject.SetActive(true);
        }

        public override void Cancel()
        {
            gameObject.SetActive(false);
        }
    }
}
