using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 interface IBasicFire
{
    bool CheckButton { get; }
    string AxisFire { get; }

    void Fire();
}

