using System;
using UnityEngine;

namespace Assets.Scripts.Core.Character.Stats
{
    [Serializable]
    public class BaseStats
    {
        public BaseStats(float attack, float defense, float hitPoints, float movement)
        {
            Attack = attack;
            Defense = defense;
            HitPoints = hitPoints;
            Movement = movement;
        }
        [SerializeField] public float Attack;
        [SerializeField] public float Defense;
        [SerializeField] public float HitPoints;
        [SerializeField] public float Movement;       
    }
}