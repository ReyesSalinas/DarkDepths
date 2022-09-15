using System.Collections.Generic;
using System.Dynamic;
using UnityEditor;
using UnityEngine;

namespace Assets.Game.Data
{
    [CreateAssetMenu(fileName = "JobStore", menuName = "RPG Project/ New ExperienceStore", order = 0)]
    public class ExperienceStore : ScriptableObject
    {
        [SerializeField] List<int> ExperienceNeededForLevel;
        public int GetExperienceForLevel(int level)
        {
            return ExperienceNeededForLevel[level - 1];
        }

        public int GetLevel(int experience)
        {
            return ExperienceNeededForLevel.FindLastIndex(level => level >= experience) + 1;
        }
    }
}