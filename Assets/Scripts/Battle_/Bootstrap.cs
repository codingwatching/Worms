﻿using BattleStateMachineComponents;
using BattleStateMachineComponents.StatesData;
using Infrastructure;
using UI;
using UnityEngine;
using PlayerInput = InputService.PlayerInput;

namespace Battle_
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private CoroutinePerformer _coroutinePerformer;
        [SerializeField] private BattleStateMachineData _data;
        
        private Battle _battle;
        private MainInput _mainInput;
        private PlayerInput _input;
    
        private void Start()
        {
            _coroutinePerformer.Init();
            _mainInput = new MainInput();
        
            _data.GlobalBattleData.Init(_mainInput, _data.StartStateData.GameConfig.TimersConfig);
            _battle = new Battle(_data);
        
            _battle.Start();
        }
    
        private void Update()
        {
            _battle?.Tick();
        }

        private void FixedUpdate()
        {
            _battle?.FixedTick();
        }
        
        private void LateUpdate()
        {
            _battle?.LateTick();
        }

        private void OnDestroy()
        {
            if (_battle != null) _battle.Dispose();
        }
    }
}
