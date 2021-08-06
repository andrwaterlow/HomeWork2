using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    [Serializable]
    class Player : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] internal float _hp;
        [SerializeField] private float _acceleration;
        private GameObject _bullet;
        [SerializeField] private Transform _barrel;
        [SerializeField] internal float _force;
        [SerializeField] private Rigidbody _myShip;
        [SerializeField] internal float _attack;
        [SerializeField] private int[] keys;
        [SerializeField] private GameObject[] values;
        [SerializeField] private Text _text;
        [SerializeField] private Interface playerInterface;
        [SerializeField] private TimeBody timeBody;
       
        IShoot superShoot;
        IShoot justShoot;
        HighDamageIsOn highDamageIsOn;
        ProxyFire proxyFire;
        DictionaryToInspecktor dictionaryToInspecktor;
        PointsInterpreter pointsInterpreter; 

        private int damage = 1;
        private Enter _enter;
        private Camera _camera;
        private Ship _ship;
        private bool _isAlive;
        private int point = 0;
        private string pointOnScreen;

        private const int pointPanel = 1;
        private const int healthPanel = 2;
        private const int exit = 3;

        private void Start()
        {
            _bullet = (GameObject)Resources.Load("Bullets");
            _camera = Camera.main;

            justShoot = new Bullet(_force);
            superShoot = new SuperBullet(justShoot);

            var move = new Acceleration(_myShip, _speed, _acceleration);
            var moveFaster = new AccelerationSuper(_myShip, _speed, _acceleration);
            var rotation = new ShipRotation(transform);
            var tribleShoot = new BulletTrible(_force);
            var damage = new TakeDamage();
            var check = new TakeDamage();
            _ship = new Ship(moveFaster, rotation, justShoot, damage, check);
            _enter = new Enter();
            _bullet = (GameObject)Resources.Load("Bullets");

            highDamageIsOn = new HighDamageIsOn();
            proxyFire = new ProxyFire(justShoot, highDamageIsOn, _force);

            dictionaryToInspecktor = new DictionaryToInspecktor();
            getDictionary();

            pointsInterpreter = new PointsInterpreter();
            _text.text =  $"{pointOnScreen}";

            getAbility();    
        }

        private void Update()
        {
            RotateShip();
            MoveShip();
            Fire();
            Acceleration();
            checkButtonPower();
            checkRewind();
            controlWindow();
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
                proxyFire.Fire(); 
                _bullet.Create(); 
                _ship.CreateBullet(_bullet);
                getPoint();
            }
        }

        private void getPoint()
        {
            point += 1000;
            pointOnScreen = pointsInterpreter.Interpret(Convert.ToString(point));
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

        private void checkButtonPower()
        {
            _enter.getBoolPower();
            if (_enter.CheckPower)
                getPower();
        }

        private void getPower()
        {
            var power = new Modifier(this);
            power.Add(new AddModifierAttack(this, 100));
            power.Add(new AddModifierHP(this, 100));
            power.Add(new AddModifierSpeed(this, 10));
            power.Handle();
        }    

        private void getAbility()
        {
            var ability = new List<IAbility>
            {
                new Ability("PlasmaShot", 500, Target.EnemyShip, DamageType.Plasma),
                new Ability("LaserShot", 250, Target.Asteroid, DamageType.Laser)
            };
        }

        private void FixedUpdate()
        {
            timeBody.chooseRewindOrRecord();       
        }

        private void checkRewind()
        {
            _enter.getBoolRewind();
            if(_enter.checkRewind)
            {
                timeBody.StarRewind();
            }
            else
            {
                timeBody.StopRewind();
            }
        }

        private void controlWindow()
        {
            _enter.choosePanel();
            if (_enter.Window == pointPanel) playerInterface.openPointPanel();
            if (_enter.Window == healthPanel) playerInterface.openHealthPanel();
            if (_enter.Window == exit) playerInterface.exitPanel();
        }
    }
}
