using Assets.Scripts.Core.Character.Stats;

namespace Assets.Scripts.Core.Jobs
{
    public interface IJob
    {
        string Name { get; set; }
        float Level { get; set; }
        BaseStats JobBonusBaseStats { get; set; }
        BaseStats JobBonusGrowth { get; set; }
        BaseStats JobBonus { get; }
    }
}