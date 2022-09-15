using Assets.Scripts.Core.Character;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.UI.HUD
{
    public class TargetHealthDisplay : HealthDisplay
    {
        public void SetHealthForTarget(GameObject gameObject)
        {
            health = gameObject.GetComponent<Health>();
            UpdateMaxHealth(gameObject);
            health.onDamageTaken += UpdateHealthBar;
            UpdateHealthBar();
        }
    }
}

