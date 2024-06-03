using System;
using System.Collections.Generic;
using EventProviders;
using UnityEngine;
using WormComponents;
using static UnityEngine.Object;

namespace Factories
{
    public class WormInfoFactory : IDisposable
    {
        private readonly WormInformationView _wormInfoPrefab;
        private readonly IWormEvents _wormEvents;
        private List<IFixedTickable> _fixedTickables = new();
        private readonly Dictionary<IWorm, WormInformationView> _informationViews = new();

        public WormInfoFactory(WormInformationView prefab, IWormEvents wormEvents)
        {
            _wormInfoPrefab = prefab;
            _wormEvents = wormEvents;
            
            _wormEvents.WormCreated += CreateInfoView;
            _wormEvents.WormDied += OnWormDied;
        }

        public void Dispose()
        {
            _wormEvents.WormCreated -= CreateInfoView;
            _wormEvents.WormDied -= OnWormDied;
        }

        private void CreateInfoView(IWorm worm, Color teamColor, string wormName)
        {
            WormInformationView wormInfo = Instantiate(_wormInfoPrefab);
            wormInfo.Init(worm, teamColor, wormName);
            
            _informationViews.Add(worm, wormInfo);
        }

        private void OnWormDied(IWorm worm)
        {
            Destroy(_informationViews[worm].gameObject);
            _informationViews.Remove(worm);
        }
    }
}