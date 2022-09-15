using System;
using System.Collections.Generic;
using Assets.Scripts.Core.Character.Stats;
using Assets.Scripts.Core.Jobs;
using Assets.Scripts.Core.Item;
using UnityEngine;
using Game.Data;

namespace Assets.Scripts.Core.Character
{
    public abstract class Character : MonoBehaviour
    {
        public Guid Id { get; set; }
        [SerializeField] public string Name;

        [SerializeField] public JobName Job;
        
        public float JobLevel = 1;

        [SerializeField] public JobStore JobsStore;

        [SerializeField] public BaseStats Stats;

        public virtual void Start()
        {               
                 
        }
        public virtual void LevelUp()
        {
            JobLevel += 1;
        }

        public virtual float Attack()
        {
            return Stats.Attack + JobsStore.GetJob(Job).GetAttack(JobLevel);
        }

        public virtual float HitPoints()
        {
            return Stats.HitPoints + JobsStore.GetJob(Job).GetHitPoints(JobLevel);
        }

        public virtual float Defense()
        {
            return Stats.Defense + JobsStore.GetJob(Job).GetDefense(JobLevel);
        }

        public virtual float Movement()
        {
            return Stats.Movement + JobsStore.GetJob(Job).GetMovement(JobLevel);
        }

    }
}