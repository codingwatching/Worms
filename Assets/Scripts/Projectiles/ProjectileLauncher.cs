using System;
using System.Collections.Generic;
using EventProviders;
using Pools;
using UnityEngine;

namespace Projectiles
{
    public class ProjectileLauncher : IDisposable, IProjectileEvents
    {
        private readonly IWeaponSelectedEvent _weaponSelectedEvent;
        private readonly IWeaponShotEvent _weaponShotEvent;
        private readonly WeaponView _weaponView;
        private ProjectilePool _pool;
        private readonly List<Projectile> _projectilesToUnsubscribe = new();
        
        public event Action<Projectile, Vector2> ProjectileLaunched;
        public event Action<Projectile> ProjectileExploded;

        public ProjectileLauncher(IWeaponSelectedEvent weaponSelectedEvent, IWeaponShotEvent weaponShotEvent, 
            WeaponView weaponView)
        {
            _weaponSelectedEvent = weaponSelectedEvent;
            _weaponShotEvent = weaponShotEvent;
            _weaponView = weaponView;

            _weaponSelectedEvent.WeaponSelected += OnWeaponSelected;
            _weaponShotEvent.WeaponShot += OnWeaponShot;
        }

        public void Dispose()
        {
            _weaponSelectedEvent.WeaponSelected -= OnWeaponSelected;
            _weaponShotEvent.WeaponShot -= OnWeaponShot;

            foreach (var projectile in _projectilesToUnsubscribe) 
                projectile.Exploded -= OnExploded;
        }

        private void OnWeaponSelected(Weapon weapon)
        {
            _pool = weapon.Config.ProjectilePool;
        }

        private void OnWeaponShot(float shotPower)
        {
            Projectile projectile = _pool.Get();
            Transform spawnPoint = _weaponView.SpawnPoint;
            Vector3 velocity = _weaponView.transform.right * shotPower;
            
            projectile.transform.position = spawnPoint.position;
            projectile.Launch(velocity, spawnPoint);
            
            projectile.Exploded += OnExploded;
            _projectilesToUnsubscribe.Add(projectile);
            
            ProjectileLaunched?.Invoke(projectile, velocity);
        }

        private void OnExploded(Projectile projectile)
        {
            ProjectileExploded?.Invoke(projectile);
        }
    }
}