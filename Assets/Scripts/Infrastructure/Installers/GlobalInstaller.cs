using System.Collections.Generic;
using Battle_;
using Configs;
using Factories;
using GameStateMachineComponents;
using GameStateMachineComponents.States;
using InputService;
using UI;
using UnityEngine;
using Weapons;
using Zenject;

namespace Infrastructure.Installers
{
    public class GlobalInstaller : MonoInstaller
    {
        [Header("Prefabs")]
        [SerializeField] private WeaponSelectorItem _weaponSelectorItemPrefab;
        [SerializeField] private FollowingTimerView _followingTimerViewPrefab;
        [SerializeField] private MainMenu _mainMenuPrefab;
        [SerializeField] private LoadingScreen _loadingScreenPrefab;
        
        [Header("Configs")]
        [SerializeField] private WeaponConfig[] _weaponConfigs;
        
        [SerializeField] private CoroutinePerformer _coroutinePerformer;
        
        private GameStateMachine _gameStateMachine;

        public override void InstallBindings()
        {
            BindInfrastructure();
            BindGameStateMachine();
            BindInput();
            BindConfigs();
            BindPrefabs();
        }

        private void BindInfrastructure()
        {
            Container.BindInterfacesAndSelfTo<CoroutinePerformer>().FromInstance(_coroutinePerformer).AsSingle().NonLazy();
            Container.BindInterfacesAndSelfTo<SceneLoader>().FromNew().AsSingle().NonLazy();
            Container.BindInterfacesAndSelfTo<BattleSettings>().FromNew().AsSingle();
            Container.BindInterfacesAndSelfTo<MainMenu>().FromComponentInNewPrefab(_mainMenuPrefab).AsSingle();
            Container.BindInterfacesAndSelfTo<LoadingScreen>().FromComponentInNewPrefab(_loadingScreenPrefab).AsSingle();
        }

        private void BindGameStateMachine()
        {
            Container.BindInterfacesAndSelfTo<GameStateMachine>().FromNew().AsSingle().NonLazy();
        }

        private void BindInput()
        {
            var mainInput = new MainInput();
            
            Container.BindInterfacesAndSelfTo<CameraInput>().AsSingle();
            Container.BindInterfacesAndSelfTo<WeaponSelectorInput>().AsSingle().WithArguments(mainInput.UI);
            Container.BindInterfacesAndSelfTo<WeaponInput>().AsSingle().WithArguments(mainInput.Weapon);
            Container.BindInterfacesAndSelfTo<MovementInput>().AsSingle();
        }

        private void BindConfigs()
        {
            Container.BindInstance(_weaponConfigs).AsSingle();
        }

        private void BindPrefabs()
        {
            Container.BindInstance(_weaponSelectorItemPrefab).AsSingle();
            Container.BindInstance(_followingTimerViewPrefab).AsSingle();
        }
    }
}