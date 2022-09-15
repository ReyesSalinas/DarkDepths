using Assets.Scripts.Handlers;
using UnityEngine;

namespace Assets.Scripts.Core.Character
{
    public class EnemyCharacter : Character
    {
        [SerializeField] int ExperienceValue;
        public override void Start()
        {
            base.Start();
            GetComponent<EnemyHealth>().OnDeath = GiveExperience;
        }        

        private void GiveExperience()
        {
            GameObject.FindWithTag("Player")
                .GetComponent<Experience>()
                .GainExperience(ExperienceValue);
        }
    }
}