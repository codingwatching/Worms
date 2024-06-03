using BattleStateMachineComponents.StatesData;
using Configs;
using Infrastructure;
using Projectiles;
using Timers;
using UI;
using UnityEngine;
using WormComponents;

namespace BattleStateMachineComponents.States
{
    public class TurnState : IBattleState
    {
        private readonly IStateSwitcher _stateSwitcher;
        private readonly GlobalBattleData _data;
        private readonly TurnStateData _turnStateData;
        private TimersConfig TimersConfig => _data.TimersConfig;
        private Timer GlobalTimer => _data.GlobalTimer;
        private Timer TurnTimer => _data.TurnTimer;

        private Team CurrentTeam { set => _data.CurrentTeam = value; }


        private IWorm CurrentWorm
        {
            get => _data.CurrentWorm;
            set => _data.CurrentWorm = value;
        }

        public TurnState(IStateSwitcher stateSwitcher, GlobalBattleData data, TurnStateData turnStateData)
        {
            _stateSwitcher = stateSwitcher;
            _data = data;
            _turnStateData = turnStateData;
        }

        public void Enter()
        {
            CurrentTeam = _turnStateData.AliveTeams.Next();
            CurrentWorm = _data.CurrentTeam.Worms.Next();
            
            CurrentWorm.SetCurrentWormLayer();
            CurrentWorm.UnfreezePosition();
            CurrentWorm.Input.Enable();

            _turnStateData.WeaponChanger.ChangeWorm(CurrentWorm);
            _turnStateData.Arrow.StartMove(CurrentWorm.Transform);
            _data.FollowingCamera.SetTarget(CurrentWorm.Transform);
            
            _data.PlayerInput.ChangeWorm(CurrentWorm);
            _data.PlayerInput.UIInput.Enable();
            
            _turnStateData.WormEvents.WormDied += OnWormDied;
            _turnStateData.AllProjectileEvents.Launched += OnLaunched;
            
            GlobalTimer.Resume();
            TurnTimer.Start(TimersConfig.TurnDuration, OnTimerElapsed);
        }

        public void Exit()
        {
            TurnTimer.Stop();
            GlobalTimer.Pause();
            _turnStateData.WeaponSelector.Close();
            
            // _data.PlayerInput.DisableAll();
            CurrentWorm.Input.Disable();
            CurrentWorm.RemoveWeapon();
            _turnStateData.AllProjectileEvents.Launched -= OnLaunched;
            _turnStateData.WormEvents.WormDied -= OnWormDied;
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
            // _data.PlayerInput.MovementInput.Tick();
            _data.PlayerInput.WeaponInput.Tick();
        }

        private void OnWormDied(IWorm worm)
        {
            _stateSwitcher.SwitchState<ProjectilesWaiting>();
        }

        private void OnLaunched(Projectile projectile, Vector2 velocity)
        {
            _data.FollowingCamera.SetTarget(projectile.transform);
            
            _stateSwitcher.SwitchState<RetreatState>();
        }

        private void OnTimerElapsed()
        {
            FinishShotIfNecessary();
            _stateSwitcher.SwitchState<ProjectilesWaiting>();
        }

        private void FinishShotIfNecessary()
        {
            if (CurrentWorm.Weapon?.CurrentShotPower > 0) 
                CurrentWorm.Weapon.Shoot();
        }
    }
}