using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{   
    [Serializable]
    internal sealed class  TakeDamage : ITakeDamage, ICheck, Subject
    {
        public GameObject GameObject { get;  set; }
        public bool IsAlive { get; set; } = true;
        private List<Observer> _observers = new List<Observer>();

        public void MakeDamage(float currentHP, int damage)
        {
            if (IsAlive)
            {
                currentHP -= damage;
            }
            DeatOrLive(currentHP);
        }

        public bool DeatOrLive(float currentHP)
        {
            if (currentHP <= 0)
            {
                notifyObserver();
                return IsAlive = false;
            }
            else
            {
                return IsAlive = true;
            }
        }

        public void registerObserver(Observer observer)
        {
            _observers.Add(observer);
        }

        public void removeObserver(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void notifyObserver()
        {
            foreach (var observer in _observers)
            {
                observer.update();
            }
        }
    }
}

