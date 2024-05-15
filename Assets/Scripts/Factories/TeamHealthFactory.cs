using System.Collections.Generic;
using UnityEngine;

public class TeamHealthFactory : MonoBehaviour
{
    [SerializeField] private TeamHealth _teamHealthTemplate;
    [SerializeField] private Transform _container;
    
    public void Create(List<Team> teams)
    {
        foreach (var team in teams)
        {
            var teamHealth = Instantiate(_teamHealthTemplate, _container);
            teamHealth.Init(team.Color, team);
        }
    }
}