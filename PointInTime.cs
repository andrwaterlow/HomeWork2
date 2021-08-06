using UnityEngine;

namespace Assets.Scripts
{
    public sealed class PointInTime
    {
        public Vector3 Position;
        public Quaternion Rotation;
        public Vector3 Velocity;
        public Vector3 AngularVelocity;

        public PointInTime (Vector3 position, Quaternion rotation, 
            Vector3 velocity, Vector3 AngularVelocity)
        {
            this.Position = position;
            this.Rotation = rotation;
            this.Velocity = velocity;
            this.AngularVelocity = AngularVelocity;
        }
    }
}
