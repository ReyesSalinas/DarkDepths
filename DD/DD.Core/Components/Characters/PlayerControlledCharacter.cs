using DD.Core.Components.Characters.Jobs;

namespace DD.Core.Components.Characters
{
    public class PlayerCharacter : Character
    {
        public int StatPoints { get; private set; }

        public override void LevelUp()
        {
            base.LevelUp();
            var statGrowth = ((PlayableJob) Job).StatPointGrowth;
            IncreaseStatPoints(statGrowth);
        }

        public void IncreaseStatPoints(int amount)
        {
            StatPoints += amount;
        }

        public void SubtractStatPoints(int amount)
        {
            StatPoints -= amount;
        }
        
    }
}