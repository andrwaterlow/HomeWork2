namespace Assets.Scripts
{
    interface IBasicFire
    {
        bool CheckButton { get; }
        string AxisFire { get; }

        void Fire();
    }
}

