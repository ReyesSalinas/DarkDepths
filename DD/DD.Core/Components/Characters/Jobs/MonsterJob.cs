using System;
using Stats;

namespace DD.Core.Components.Characters.Jobs
{
    public class MonsterJob : IJob
    {
        public MonsterJob(string name, BaseStats jobBonusBaseStats)
        {
            Name = name;
            JobBonusBaseStats = jobBonusBaseStats;
        }

        public string Name { get; set; }
        public float Level { get; set; }
        public BaseStats JobBonusBaseStats { get; set; }
        public BaseStats JobBonusGrowth { get; set; }
        public BaseStats JobBonus { get; set; }

        public void LevelUp()
        {
            throw new NotImplementedException();
        }
    }
}