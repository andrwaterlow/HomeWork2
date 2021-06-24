using UnityEngine;


internal sealed class Asteroids : Enemy
{
    public Health Health { get; private set; }
    GameObject Asteroid;
    public Asteroids(Health health)
    {
        Health = health;
    }
    public void Init()
    {
       Asteroid = (GameObject)GameObject.Instantiate(Resources.Load("Asteroid"));
    }
}

