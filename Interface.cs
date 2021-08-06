using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    class Interface : MonoBehaviour
    {
        [SerializeField] private PointPanel _pointPanel;
        [SerializeField] private HealthPanel _healthPanel;
        private readonly Stack<StateUI> _stateUI =
            new Stack<StateUI>();
        private BaseUI _currentWindow;

        private void Execute(StateUI stateUI, bool IsSave = true)
        {
            if (_currentWindow != null)
            {
                _currentWindow.Cancel();
            }

            switch (stateUI)
            {
                case StateUI.PointPanel:
                    _currentWindow = _pointPanel;
                    break;
                case StateUI.HealthPanel:
                    _currentWindow = _healthPanel;
                    break;
                default:
                    break;
            }

            _currentWindow.Execute();
            if (IsSave)
            {
                _stateUI.Push(stateUI);
            }   
        }

        public void openPointPanel()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Execute(StateUI.PointPanel);
            }
        }

        public void openHealthPanel()
        {
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                Execute(StateUI.HealthPanel);
            }
        }

        public void exitPanel()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (_stateUI.Count > 0)
                {
                    Execute(_stateUI.Pop(), false);
                }
            }
        }
    }
}
