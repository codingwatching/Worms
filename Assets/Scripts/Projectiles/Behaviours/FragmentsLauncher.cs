using System;
using System.Collections.Generic;
using System.Linq;
using Configs;
using Pools;
using Projectiles.Behaviours.Components;
using Timers;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Projectiles.Behaviours
{
    public class FragmentsLauncher : IDisposable
    {
        private readonly IProjectileEvents _projectileEvents;
        private readonly List<ProjectilePool> _fragmentPoolsList;
        private readonly Dictionary<ProjectileConfig, ProjectilePool> _fragmentPools;
        private readonly float _launchDelay = 0.15f;
        private readonly Timer _timer;
        private ProjectilePool _fragmentPool;

        public FragmentsLauncher(IProjectileEvents projectileEvents, List<ProjectilePool> fragmentPoolsList)
        {
            _projectileEvents = projectileEvents;
            _fragmentPoolsList = fragmentPoolsList;
            _fragmentPools = fragmentPoolsList
                .Where(pool => pool.Config != null)
                .ToDictionary(pool => pool.Config);

            _timer = new Timer();

            _projectileEvents.Exploded += OnExploded;
        }


        public void Dispose()
        {
            _projectileEvents.Exploded -= OnExploded;
        }

        private void OnExploded(Projectile projectile)
        {
            int fragmentsAmount = projectile.Config.FragmentsAmount;
            var fragmentConfig = projectile.Config.FragmentsConfig;
            
            if (fragmentConfig == null) 
                return;
            
            _fragmentPool = _fragmentPools[fragmentConfig];
            _timer.Start(_launchDelay, () => LaunchFragments(projectile, fragmentsAmount));
        }
        
        private void LaunchFragments(Projectile projectile, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Projectile fragment = _fragmentPool.Get();
                fragment.transform.position = projectile.transform.position;
                fragment.Launch(new Vector2(Random.Range(-2f, 2f), Random.Range(4f, 6f)), projectile.Config.FragmentsDamage);
            }
        }
    }
}