using System;
using UnityEngine;

namespace Assets.Scripts
{
    [Serializable]
    class Player : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _hp;
        [SerializeField] private float _acceleration;
        private GameObject _bullet;
        [SerializeField] private Transform _barrel;
        [SerializeField] private float _force;
        [SerializeField] private Rigidbody _myShip;
        [SerializeField] private int[] keys;
        [SerializeField] private GameObject[] values;

        IShoot superShoot;
        IShoot justShoot;
        HighDamageIsOn highDamageIsOn;
        ProxyFire proxyFire;
        DictionaryToInspecktor dictionaryToInspecktor;

        private int damage = 1;
        private Enter _enter;
        private Camera _camera;
        private Ship _ship;
        private bool _isAlive;

        private void Start()
        {
            _bullet = (GameObject)Resources.Load("Bullets");
            _camera = Camera.main;
            var move = new Acceleration(_myShip, _speed, _acceleration);
            var moveFaster = new AccelerationSuper(_myShip, _speed, _acceleration);
            var rotation = new ShipRotation(transform);

            justShoot = new Bullet(_force);
            superShoot = new SuperBullet(justShoot); // декорированная пуля
            
            var tribleShoot = new BulletTrible(_force);
            var damage = new TakeDamage();
            var check = new TakeDamage();
            _ship = new Ship(moveFaster, rotation, justShoot, damage, check);
            _enter = new Enter();
            _bullet = (GameObject)Resources.Load("Bullets");

            highDamageIsOn = new HighDamageIsOn();
            proxyFire = new ProxyFire(justShoot, highDamageIsOn);

            dictionaryToInspecktor = new DictionaryToInspecktor();
            getDictionary();
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
            {
                highDamageIsOn.highDamage = true;
                proxyFire.Fire(); // стрельба через прокси проходящая через декоратор
                _bullet.Create(); // метод расширения(строитель)
                _ship.CreateBullet(_bullet);
            }
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

        private void getDictionary()
        {
            int maxcount = dictionaryToInspecktor.dic.Count;
            keys = dictionaryToInspecktor.keys;
            values = dictionaryToInspecktor.values;
        }
    }
}
