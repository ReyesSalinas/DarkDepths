using Assets.Scripts.Core.Character;
using Assets.Scripts.Handlers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.UI.HUD
{
    public class PlayerHealthDisplay : HealthDisplay
    {
        [SerializeField] string TargetHealth;
        // Start is called before the first frame update
        protected override void Start()
        {
            var gameObject = GameObject.FindWithTag(TargetHealth);
            if (gameObject == null)
            {
                return;
            }
            gameObject.GetComponent<Experience>().onLevelUp += LevelUp;
            health = gameObject.GetComponent<Health>();
            health.onDamageTaken += UpdateHealthBar;
            UpdateMaxHealth(GameObject.FindWithTag(TargetHealth));
            UpdateHealthBar();
            base.Start();
        }

        private void LevelUp()
        {
            print("Level Up Update Health Bar");
            UpdateMaxHealth(GameObject.FindWithTag(TargetHealth));
            UpdateHealthBar();
        }       
    }
}

