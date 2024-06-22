using Pools;
using Timers;

namespace BattleStateMachineComponents.States
{
    public class ProjectilesWaiting : IBattleState
    {
        private readonly IStateSwitcher _stateSwitcher;
        private readonly Timer _timer;

        public ProjectilesWaiting(IStateSwitcher stateSwitcher)
        {
            _stateSwitcher = stateSwitcher;
            _timer = new Timer();
        }

        public void Enter()
        {
            OnCountChanged(ProjectilePool.Count);
            
            ProjectilePool.CountChanged += OnCountChanged;
        }

        public void Exit()
        {
            ProjectilePool.CountChanged -= OnCountChanged;
        }

        public void Tick()
        {
        }

        public void FixedTick()
        {
        }

        public void LateTick()
        {
        }

        public void HandleInput()
        {
        }

        private void OnCountChanged(int count)
        {
            if(count == 0 && _timer.Started == false)
            {
                _timer.Start(3, () =>
                {
                    if(count == 0)
                        _stateSwitcher.SwitchState<BetweenTurnsState>();
                });
            }
                

        }
    }
}