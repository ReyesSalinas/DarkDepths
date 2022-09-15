using DD.Core.Components.Characters;

namespace DD.Core.Components
{
    public class ExperienceManager
    {
        public ExperienceManager(float currentLevel, float currentExperience)
        {
            CurrentLevel = currentLevel;
            CurrentExperience = currentExperience;
        }

        public float CurrentLevel { get; set; }

        public float ExperienceToNextLevel => CurrentLevel * 1000 - CurrentExperience;
        public float CurrentExperience { get; private set; }

        public void addExperience(float experience)
        {
            if (CurrentExperience + experience > ExperienceToNextLevel)
                CurrentExperience = ExperienceToNextLevel;
            else
                CurrentExperience += experience;
        }

        public void subtractExperience(float experience)
        {
            CurrentExperience -= experience;
        }

        public void Update(Character character)
        {
            if (ExperienceToNextLevel == 0) character.LevelUp();
        }
    }
}