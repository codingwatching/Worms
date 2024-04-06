using ScriptBoy.Digable2DTerrain;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

public class WormsSpawner : MonoBehaviour
{
    [SerializeField] private int _teamsNumber = 2;
    [SerializeField] private int _wormsNumber = 4;
    [SerializeField] private List<Color> _teamColors;

    [SerializeField] private Terrain2D _terrain;
    [SerializeField] private Team _teamTemplate;
    [SerializeField] private Worm _wormTemplate;
    [SerializeField] private Transform _container;
    [SerializeField] private float _maxSlope = 45;
    [SerializeField] private MapBounds _mapBounds;

    private Vector2[] _points;
    private List<Edge> _edges = new();

    private const string TeamsNumber = nameof(TeamsNumber);
    private const string WormsNumber = nameof(WormsNumber);

    public event UnityAction<Worm> WormSpawned;

    private void Awake()
    {
        _teamsNumber = PlayerPrefs.GetInt(TeamsNumber, _teamsNumber);
        _wormsNumber = PlayerPrefs.GetInt(WormsNumber, _wormsNumber);
    }

    public List<Team> SpawnTeams()
    {
        if(_teamColors.Count < _teamsNumber)
            throw new ArgumentOutOfRangeException($"{nameof(_teamColors)} count cant be less then {nameof(_teamsNumber)}");

        List<Team> teams = new List<Team>();

        for (int i = 0; i < _teamsNumber; i++)
        {
            var randomColor = _teamColors[Random.Range(0, _teamColors.Count)];
            _teamColors.Remove(randomColor);

            var newTeam = SpawnTeam(_wormsNumber, randomColor, $"Team {i + 1}");
            teams.Add(newTeam);
        }
        return teams;
    }

    private Team SpawnTeam(int wormsNumber, Color teamColor, string teamName)
    {
        List<Worm> worms = new List<Worm>();

        var team = Instantiate(_teamTemplate, _container);

        for (int i = 0; i < wormsNumber; i++)
        {
            var newWorm = Instantiate(_wormTemplate, GetRandomPointForSpawn(), Quaternion.identity, team.transform);
            newWorm.SetRigidbodyKinematic();
            WormSpawned?.Invoke(newWorm);
            worms.Add(newWorm);
        }

        team.Init(worms, teamColor, teamName);
        team.name = teamName;
        return team;
    }

    public void GetEdgesForSpawn()
    {
        int length = _terrain.polygonCollider.points.Length;
        _points = new Vector2[length];
        Array.Copy(_terrain.polygonCollider.points, _points, length);

        for (int i = 0; i < _points.Length; i++)
        {
            int j = i + 1;
            if (j >= _points.Length)
                j = 0;

            var newEdge = new Edge(_points[i], _points[j]);
            bool edgeInBounds = newEdge.InBounds(_mapBounds.Left.position, _mapBounds.Top.position, 
                _mapBounds.Right.position, _mapBounds.Bottom.position, _terrain);

            if (newEdge.IsFloor(_terrain) && newEdge.IsSuitableSlope(_maxSlope) && edgeInBounds)
                _edges.Add(newEdge);
        }
    }

    private Vector2 GetRandomPointForSpawn()
    {
        Vector2 randomPoint;
        do
        {
            int random = Random.Range(0, _edges.Count);
            var randomEdge = _edges[random];
            randomPoint = Vector2.Lerp(randomEdge.Point1, randomEdge.Point2, Random.value);
            randomPoint += (Vector2)_terrain.transform.position;
        }
        while (!CanFitWormInPosition(randomPoint));

        return randomPoint;
    }

    private bool CanFitWormInPosition(Vector2 position)
    {
        var size = new Vector2(_wormTemplate.Collider2D.size.x * 2, _wormTemplate.Collider2D.size.y);
        return !Physics2D.OverlapCapsule(position + new Vector2(0, 0.5f), size, CapsuleDirection2D.Vertical, 0);
    }
}
