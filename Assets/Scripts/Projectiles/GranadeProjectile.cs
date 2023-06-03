using ScriptBoy.Digable2DTerrain;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GranadeProjectile : Projectile
{
    [SerializeField] private float _explodeDelay = 5;

    public override void Init(Vector2 value, ExplosionPool explosionPool, Shovel shovel)
    {
        base.Init(value, explosionPool, shovel);
        var torque = Random.Range(5, 7);
        Rigidbody2D.AddTorque(Random.Range(-torque, torque));
        DelayedExplode(_explodeDelay);
    }

    protected override void OnCollisionEnter2D(Collision2D collision)
    {
    }
}
