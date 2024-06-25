using System.Collections;
using Infrastructure;
using UnityEngine;
using Zenject;
using Input = UnityEngine.Input;

namespace Projectiles.Behaviours.Components
{
    public class ExplodeOnKeyDown : MonoBehaviour
    {
        [SerializeField] private Projectile _projectile;
        
        private Coroutine _coroutine;
        private ICoroutinePerformer _coroutinePerformer;
        private WaitForSeconds _waitForEnableKey;
        private readonly float _secondsToEnableKey = 1;

        public void Awake()
        {
            _waitForEnableKey = new WaitForSeconds(_secondsToEnableKey);
        }

        [Inject]
        private void Construct(ICoroutinePerformer coroutinePerformer)
        {
            _coroutinePerformer = coroutinePerformer;
        }

        private void OnEnable()
        {
            _projectile.Launched += OnLaunch;
            _projectile.Exploded += OnExploded;
        }

        private void OnDisable()
        {
            _projectile.Launched -= OnLaunch;
            _projectile.Exploded -= OnExploded;
        }

        public void OnLaunch(Projectile projectile, Vector2 vector2)
        {
            _coroutine = StartCoroutine(WaitKeyDown());
        }

        private void OnExploded(Projectile projectile)
        {
            _coroutinePerformer.StopCoroutine(_coroutine);
        }

        private IEnumerator WaitKeyDown()
        {
            yield return _waitForEnableKey;
            
            while (Input.GetKeyDown(KeyCode.Space) == false)
                yield return null;

            _projectile.Explode();
        }
    }
}