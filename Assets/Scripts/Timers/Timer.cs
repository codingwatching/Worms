using System;
using System.Collections;
using Infrastructure;
using UnityEngine;

namespace Timers
{
    public class Timer : ITimerUpdateEvent
    {
        private double _interval;
        private double _timeLeft = 0;
        private Coroutine _coroutine;
        private bool _paused;
        [field: SerializeField] public bool Started { get; private set; }
        
        public event Action<double> TimerUpdated;

        public void Start(float interval, Action onElapsed)
        {
            _interval = interval;
            _timeLeft = _interval;
            Started = true;
            TimerUpdated?.Invoke(_timeLeft);
            _coroutine = CoroutinePerformer.StartCoroutine(StartTimer(onElapsed));
        }

        public void Stop()
        {
            if(_coroutine != null)
                CoroutinePerformer.StopCoroutine(_coroutine);
            
            Reset();
        }

        public void Resume()
        {
            _timeLeft = (int)_timeLeft;
            TimerUpdated?.Invoke(_timeLeft);
            _paused = false;
        }

        public void Pause() => _paused = true;

        private IEnumerator StartTimer(Action onElapsed)
        {
            while (_timeLeft > 0)
            {
                yield return null;
                
                if (_paused == true) continue;

                _timeLeft -= Time.deltaTime;
                TimerUpdated?.Invoke(_timeLeft);
            }

            Stop();
            onElapsed?.Invoke();
        }

        private void Reset()
        {
            _timeLeft = _interval;
            Started = false;
        }
    }
}