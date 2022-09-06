using Stats;

namespace DD.Core.Components.Characters.Jobs
{
    public class PlayableJob : IJob
    {
        private PlayableJob(string name, BaseStats baseStats, BaseStats jobBonusGrowth, int statPointGrowth)
        {
            Name = name;
            JobBonusBaseStats = baseStats;
            JobBonusGrowth = jobBonusGrowth;
            StatPointGrowth = statPointGrowth;
        }

        public int StatPointGrowth { get; }

        public string Name { get; set; }
        public float Level { get; set; }
        public BaseStats JobBonusBaseStats { get; set; }
        public BaseStats JobBonusGrowth { get; set; }
        public BaseStats JobBonus { get; set; }

        public void LevelUp()
        {
            JobBonus = new BaseStats(
                JobBonusBaseStats.Attack + JobBonusGrowth.Attack * Level,
                JobBonusBaseStats.Defense + JobBonusGrowth.Defense * Level,
                JobBonusBaseStats.HitPoints + JobBonusGrowth.HitPoints * Level,
                JobBonusBaseStats.Movement + JobBonusGrowth.Movement * Level
            );
        }
    }
}