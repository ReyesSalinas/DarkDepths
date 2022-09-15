using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Core.Character
{
    public class EnemyHealth : Health
    {
        public Action OnDeath;


        protected override void Die()
        {
            base.Die();
            OnDeath();
        }      
    }
}