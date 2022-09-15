using Assets.Scripts.Handlers;
using System;
using System.Runtime.InteropServices.WindowsRuntime;
using TMPro;
using UnityEngine;
namespace Assets.Scripts.Core.Character
{
    public abstract class Health : MonoBehaviour
    {
        [SerializeField] protected float amount;
        public Action onDamageTaken;
        public Action onDeath;

        public bool isDead = false;
        public virtual void Start()
        {
            var CharacterStats = GetComponent<Character>();
            
            if (!!CharacterStats)
            {
                amount = CharacterStats.HitPoints();
                return;
            }           
        }
        public void TakeDamage(float damage)
        {
            amount = Mathf.Max(amount - damage, 0);
            if (amount == 0)
            {
                Die();
                return;
            }
            onDamageTaken();
        }

      

        protected virtual void GainHealth(float gainedAmount)
        {
            amount += gainedAmount;
        }

        protected virtual void Die()
        {
            if (isDead) return;
            isDead = true;
            GetComponent<Animator>().SetTrigger("die");
            GetComponent<ActionScheduler>().CancelCurrentAction();
            onDeath();
        }

        public float GetCurrentHealth()
        {
            return amount;
        }
    }
}
