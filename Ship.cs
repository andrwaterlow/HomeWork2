using System;
using UnityEngine;

namespace Assets.Scripts
{
    [Serializable]
    internal sealed class Ship : IMove, IRotation, IShoot, IHealth
    {
        private readonly IMove _moveImplementation;
        private readonly IRotation _rotationImplementation;
        private readonly IShoot _fireImplementation;
        private readonly IHealth _healthImplementation;
        
        public float Speed => _moveImplementation.Speed;
        public float Forse => _fireImplementation.Forse;
        public TakeDamage TakeDamage => _healthImplementation.TakeDamage;

        public Ship(IMove moveImplementation, IRotation rotationImplementation, IShoot fireImplementation, IHealth healthImplementation)
        {
            _moveImplementation = moveImplementation;
            _rotationImplementation = rotationImplementation;
            _fireImplementation = fireImplementation;
            _healthImplementation = healthImplementation;
        }

        public void Movement(Rigidbody ship, float vertical, float horizontal, float deltaTime)
        {
            _moveImplementation.Movement(ship, horizontal, vertical, deltaTime);
        }

        public void Rotation(Vector3 direction)
        {
            _rotationImplementation.Rotation(direction);
        }

        public void AddAcceleration(bool checkbutton)
        {
            if (_moveImplementation is Acceleration accelerationMove)
            {
                accelerationMove.AddAcceleration(checkbutton);
            }
        }

        public void RemoveAcceleration(bool checkbutton)
        {
            if (_moveImplementation is Acceleration accelerationMove)
            {
                accelerationMove.RemoveAcceleration(checkbutton);
            }
        }

        public void FlyBullet(GameObject prefab)
        {
            _fireImplementation.FlyBullet(prefab);
        }

        public void CreateBullet(GameObject prefab)
        {
            _fireImplementation.CreateBullet(prefab);
        }

        public void DestroyBullet(GameObject prefab)
        {
            _fireImplementation.DestroyBullet(prefab);
        }

        public void MakeDamage(float currentHP, int damage)
        {
            _healthImplementation.TakeDamage.MakeDamage(currentHP, damage);
        }

        public bool DeatOrLive(float currentHP)
        {
            return _healthImplementation.TakeDamage.DeatOrLive(currentHP);
        }
    }
}
