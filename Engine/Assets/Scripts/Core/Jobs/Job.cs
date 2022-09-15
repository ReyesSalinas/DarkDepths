using UnityEngine;
using Assets.Scripts.Core.Character.Stats;
using System.Linq;
using System;

namespace Assets.Scripts.Core.Jobs
{
    public enum JobName
    {
        Soldier,
        Mage,
        Grunt,
    }

    [Serializable]
    public class Job
    {
        [SerializeField]  JobName Name;        
        [SerializeField]  BaseStats JobBonusBaseStats;
        [SerializeField]  BaseStats JobBonusGrowth;
        public  void Start()
        {           
        }  

        public BaseStats GetJobStats(float level) => new BaseStats(
               JobBonusBaseStats.Attack + JobBonusGrowth.Attack * level,
               JobBonusBaseStats.Defense + JobBonusGrowth.Defense * level,
               JobBonusBaseStats.HitPoints + JobBonusGrowth.HitPoints * level,
               JobBonusBaseStats.Movement + JobBonusGrowth.Movement * level
           );

        public JobName GetName()
        {
            return Name;
        }
        public float GetAttack(float level)
        {
            return JobBonusBaseStats.Attack + JobBonusGrowth.Attack * level;
        }
        public float GetDefense(float level)
        {
            return JobBonusBaseStats.Defense + JobBonusGrowth.Defense * level;
        }       
        public float GetHitPoints(float level)
        {
            return JobBonusBaseStats.HitPoints + JobBonusGrowth.HitPoints * level;
        }
        public float GetMovement(float level)
        {
            
                return JobBonusBaseStats.Movement + JobBonusGrowth.Movement * level;        
        }
    }
}