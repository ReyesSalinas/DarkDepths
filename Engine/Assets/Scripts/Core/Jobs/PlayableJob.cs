using Assets.Scripts.Core.Character.Stats;
using System;
using System.Linq;
using UnityEngine;

namespace  Assets.Scripts.Core.Jobs
{
    [Serializable]
    public class PlayableJob : Job
    {
        [SerializeField] public int StatPointGrowth;                      
    }
}
