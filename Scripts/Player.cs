using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


class Player : MonoBehaviour
{

        [SerializeField] private float _speed;
        [SerializeField] private float _hp;
        [SerializeField] private float _acceleration;
        [SerializeField] private GameObject _bullet;
        [SerializeField] private Transform _barrel;
        [SerializeField] private float _force;
        [SerializeField] private Rigidbody _myShip;
    

        private int damage = 1;
        private Enter _enter;
        private Camera _camera;
        private Ship _ship;
        private bool _isAlive;
       
        
        private void Start()
        {
           _camera = Camera.main;
        var move = new Acceleration(_myShip, _speed, _acceleration);
        var rotation = new ShipRotation(transform);
        var shoot = new Bullet(_force, _bullet);
        var damage = new TakeDamage();
        var check = new TakeDamage();
           _ship = new Ship(move, rotation, shoot, damage, check);
        _enter = new Enter();
        
        }

    private void Update()
        {
        RotateShip();
        MoveShip();
        Fire();
        Acceleration();
        }

    private void RotateShip()
    {
        var direction = Input.mousePosition - _camera.WorldToScreenPoint(transform.position);
        _ship.Rotation(direction);
    }

    private void MoveShip()
    {
        float AxisX = _enter.GetValueLeftRight();
        float AxisZ = _enter.GetValueUpDawn();
        _ship.Movement(_myShip, AxisX, AxisZ, Time.deltaTime);
    }

    private void Fire()
    {
      _enter.Fire();
        if (_enter.CheckButton) 
          _ship.CreateBullet(_bullet); 
    }

    private void Acceleration()
    {
        bool checkbutton = _enter.Acceleration();
        _ship.AddAcceleration(checkbutton);
        _ship.RemoveAcceleration(checkbutton);
    }

    private void OnCollisionEnter(Collision other)
    {
        _ship.MakeDamage(_hp, damage, _isAlive);
        _isAlive = _ship.DeatOrLive(_hp);
        if (!_isAlive) Destroy(gameObject);
    }


}

