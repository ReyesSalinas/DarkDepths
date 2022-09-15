using Assets.Scripts.Core.Jobs;
using Assets.Scripts.Core.Character.Stats;
using UnityEngine;
using Assets.Scripts.Handlers;
using System;

namespace Assets.Scripts.Core.Character
{
    public class PlayerControlledCharacter : Character
    {    
        [SerializeField] public int StatPoints;
        [SerializeField] public int StatPointGrowth;

        public Action onLevelUp;

        public override void Start()
        {
            base.Start();
            GetComponent<Experience>().onLevelUp += LevelUp;
        }
        public override void LevelUp()
        {            
            IncreaseStatPoints(StatPointGrowth);           
            base.LevelUp();
            onLevelUp();
        }

        public void HandleDeath()
        {

        }

        public void IncreaseStatPoints(int amount)
        {
            StatPoints += amount;
        }

        public void SubtractStatPoints(int amount)
        {
            StatPoints -= amount;
        }
        
        public void IncreaseStat(float amount, StatNames stat) {
            switch (stat)
            {
                case StatNames.Attack: Stats.Attack += amount; break;
                case StatNames.Defense: Stats.Defense += amount; break;
                case StatNames.HitPoints: Stats.HitPoints += amount; break;
                case StatNames.Movement: Stats.Movement += amount; break;                   
            }
        }

        public void DecreaseStat(float amount, StatNames stat) {
            switch (stat)
            {
                case StatNames.Attack: Stats.Attack -= amount; break;
                case StatNames.Defense: Stats.Defense -= amount; break;
                case StatNames.HitPoints: Stats.HitPoints -= amount; break;
                case StatNames.Movement: Stats.Movement -= amount; break;
            }
        }
    }
}