using System;
using Battle_;
using BattleStateMachineComponents.StatesData;
using CameraFollow;
using Configs;
using DestructibleLand;
using EventProviders;
using Factories;
using Services;
using Spawn;
using UnityEngine;
using WormComponents;
using static UnityEngine.Object;

namespace BattleStateMachineComponents.States
{
    public class WormsBootstraper : IDisposable
    {
        private readonly TerrainWrapper _terrain;
        private readonly IBattleSettings _battleSettings;
        private readonly WormsSpawner _wormsSpawner;
        private readonly GameConfig _gameConfig;
        private readonly Transform _teamHealthParent;
        private readonly CycledList<Team> _aliveTeams;
        private readonly FollowingCamera _followingCamera;
        private WormInfoFactory _wormInfoFactory;
        private WormFactory _wormFactory;

        public IWormEvents WormEvents { get; private set; }
        public ITeamDiedEventProvider TeamDiedEvent { get; private set; }

        public WormsBootstraper(TerrainWrapper terrain, IBattleSettings battleSettings, WormsSpawner wormsSpawner,
            GameConfig gameConfig, Transform teamHealthParent, CycledList<Team> aliveTeams)
        {
            _terrain = terrain;
            _battleSettings = battleSettings;
            _wormsSpawner = wormsSpawner;
            _gameConfig = gameConfig;
            _teamHealthParent = teamHealthParent;
            _aliveTeams = aliveTeams;
        }

        public void Dispose()
        {
            _wormInfoFactory.Dispose();
            _wormFactory.Dispose();
        }

        public void SpawnWorms()
        {
            int teamsNumber = _battleSettings.Data.TeamsCount;
            int wormsNumber = _battleSettings.Data.WormsCount;

            WormEvents = _wormFactory = new WormFactory(_gameConfig.WormPrefab, _terrain);
            var teamFactory = new TeamFactory(_wormFactory);
            _wormInfoFactory = new WormInfoFactory(_gameConfig.WormInfoViewPrefab, WormEvents);

            _wormsSpawner.Init(teamFactory);
            TeamDiedEvent = teamFactory;
            
            CycledList<Team> teams = _wormsSpawner.Spawn(teamsNumber, wormsNumber);

            _aliveTeams.AddRange(teams);

            TeamHealthFactory teamHealthFactory = Instantiate(_gameConfig.TeamHealthFactoryPrefab, _teamHealthParent);
            teamHealthFactory.Create(_aliveTeams, _gameConfig.TeamHealthPrefab);
            teamHealthFactory.transform.SetAsFirstSibling();
        }
    }
}