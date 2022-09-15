using Assets.Game.Data;
using Assets.Scripts.Core.Character;
using System;
using UnityEngine;

namespace Assets.Scripts.Handlers
{
    public class Experience : MonoBehaviour
    {
        [SerializeField] float currentExperience;       
        [SerializeField] ExperienceStore experienceStore;       
        public Action onLevelUp;

        public delegate void HandleExperienceGained(float currentExperience, float experienceForNextLevel);
        public HandleExperienceGained onExperienceGained;
        
        public float experienceForLevel;
        
        void Start()
        {
            currentExperience = 0;
            setExperienceForNextLevel();
            onExperienceGained(currentExperience, experienceForLevel);
        }

        public void GainExperience(int gainedExperience)
        {
            currentExperience += gainedExperience;
            if (CanLevelUp())
            {
                onLevelUp();
                setExperienceForNextLevel();
            }
            onExperienceGained(currentExperience, experienceForLevel);
        }

        private void setExperienceForNextLevel()
        {
            var currentLevel = GetComponent<PlayerControlledCharacter>().JobLevel;
            experienceForLevel = experienceStore.GetExperienceForLevel((int)currentLevel + 1);
        }

        public bool CanLevelUp()
        {
            return currentExperience >= experienceForLevel;
            
        }
        
               
    }
}