using Stats;

namespace DD.Core.Components.Characters.Jobs
{
    public interface IJob
    {
        string Name { get; set; }
        float Level { get; set; }
        BaseStats JobBonusBaseStats { get; set; }
        BaseStats JobBonusGrowth { get; set; }
        BaseStats JobBonus { get; set; }
        void LevelUp();
    }
}