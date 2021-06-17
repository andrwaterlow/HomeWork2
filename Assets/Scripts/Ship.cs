using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal sealed class Ship : IMove, IRotation, IShoot, ITakeDamage, ICheck
{
    private readonly IMove _moveImplementation;
    private readonly IRotation _rotationImplementation;
    private readonly IShoot _fireImplementation;
    private readonly ITakeDamage _damageImplementation;
    private readonly ICheck _checkImplementation;


    public float Speed => _moveImplementation.Speed;
    public float Forse => _fireImplementation.Forse;
    public GameObject GameObject => _damageImplementation.GameObject;
    public bool IsAlive => _checkImplementation.IsAlive;

    public Ship(IMove moveImplementation, IRotation rotationImplementation, IShoot fireImplementation, ITakeDamage damageImplementation,ICheck checkImplementation)
    {
        _moveImplementation = moveImplementation;
        _rotationImplementation = rotationImplementation;
        _fireImplementation = fireImplementation;
        _damageImplementation = damageImplementation;
        _checkImplementation = checkImplementation;
    }

    public void Movement(Rigidbody ship, float vertical, float horizontal, float deltaTime)
    {
        _moveImplementation.Movement(ship, horizontal, vertical, deltaTime);
    }

    public void Rotation(Vector3 direction)
    {
        _rotationImplementation.Rotation(direction);
    }

    public void AddAcceleration()
    {
        if (_moveImplementation is Acceleration accelerationMove)
        {
            accelerationMove.AddAcceleration();
        }
    }

    public void RemoveAcceleration()
    {
        if (_moveImplementation is Acceleration accelerationMove)
        {
            accelerationMove.RemoveAcceleration();
        }
    }

    public void FlyBullet(Rigidbody bullet)
    {
        _fireImplementation.FlyBullet(bullet);
    }

    public void MakeDamage(float currentHP, int damage)
    {
        _damageImplementation.MakeDamage(currentHP, damage);
    }

    public void DeatOrLive(float currentHP)
    {
        _checkImplementation.DeatOrLive(currentHP);
    }
}
