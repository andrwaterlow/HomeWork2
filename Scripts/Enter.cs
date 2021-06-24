using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class Enter: IHorizontal, IVertical, IBasicFire, IAcceleration
{
    public string AxisLeftRight { get; protected set; } = "Horizontal";
    public string AxisUpDawn  { get; protected set; } = "Vertical";
    public string AxisFire { get; protected set; } = "Fire1";

    public bool CheckButton { get; protected set; }
    public bool CheckAcceleration { get; protected set; }

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
}

