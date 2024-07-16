using System;
using Timers;
using _UI;
using UnityEngine;
using Wind_;

[Serializable]
public class UI : MonoBehaviour
{
    [field: SerializeField] public WeaponSelector WeaponSelector { get; private set; }
    [field: SerializeField] public TimerView BattleTimerView { get; private set; }
    [field: SerializeField] public TimerView TurnTimerView { get; private set; }
    [field: SerializeField] public WindView WindView { get; private set; }
}