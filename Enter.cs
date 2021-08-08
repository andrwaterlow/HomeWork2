using UnityEngine;

namespace Assets.Scripts
{
    internal class Enter : IHorizontal, IVertical, IBasicFire, IAcceleration, IPower, IRewind, IInterface, IState
    {
        public string AxisLeftRight { get; protected set; } = "Horizontal";
        public string AxisUpDawn { get; protected set; } = "Vertical";
        public string AxisFire { get; protected set; } = "Fire1";

        public bool CheckButton { get; protected set; }
        public bool CheckAcceleration { get; protected set; }

        public bool CheckPower { get; protected set; }

        public bool checkRewind { get; protected set; }

        public int Window { get; protected set; }

        public void Fire()
        {
            if (Input.GetButtonDown(AxisFire))
            {
                CheckButton = true;
            }
            else
            {
                CheckButton = false;
            }
        }

        public bool Acceleration()
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                CheckAcceleration = true;
            }
            else
            {
                CheckAcceleration = false;
            }
            return CheckAcceleration;
        }

        public float GetValueLeftRight()
        {
            return Input.GetAxis(AxisLeftRight);
        }

        public float GetValueUpDawn()
        {
            return Input.GetAxis(AxisUpDawn);
        }

        public void getBoolPower()
        {
            if (Input.GetKey(KeyCode.Q))
            {
                CheckPower = true;
            }
            else
            {
                CheckPower = false;
            }
        }

        public void getBoolRewind()
        {
            if (Input.GetKey(KeyCode.F))
            {
                checkRewind = true;
            }
            else
            {
                checkRewind = false;
            }
        }

        public void choosePanel()
        {
            if (Input.GetKey(KeyCode.Alpha1))
            {
                Window = 1;
            }
            if (Input.GetKey(KeyCode.Alpha2))
            {
                Window = 2;
            }
            if (Input.GetKey(KeyCode.Escape))
            {
                Window = 3;
            }
        }

        public int getNumberOfState()
        {
            int numberOfState;
            int forward = 1;
            int toward = 2;
            int left = 3;
            int right = 4;
            int nothing = 0;

            if (Input.GetKey(KeyCode.W))
            {
                return numberOfState = forward;
            }
            if (Input.GetKey(KeyCode.S))
            {
                return numberOfState = toward;
            }
            if (Input.GetKey(KeyCode.A))
            {
                return numberOfState = left;
            }
            if (Input.GetKey(KeyCode.D))
            {
                return numberOfState = right;
            }
            else 
            {
                return numberOfState = nothing;
            }
        }
    }
}
