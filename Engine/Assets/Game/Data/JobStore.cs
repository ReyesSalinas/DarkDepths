using Assets.Scripts.Core.Character.Stats;
using UnityEngine;
using Assets.Scripts.Core.Jobs;
using System.Linq;

namespace Game.Data
{
    [CreateAssetMenu(fileName = "JobStore", menuName = "RPG Project/ New JobStore", order = 0)]
    public class JobStore : ScriptableObject
    {
        [SerializeField] Job[] Jobs;
        
        public Job GetJob(JobName jobName)
        {
            return Jobs.First(job => job.GetName() == jobName);
        }
    }
}