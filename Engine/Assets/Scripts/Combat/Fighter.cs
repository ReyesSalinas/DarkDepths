using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts.Combat;
using Assets.Scripts.Core;
using Engine.Movement;
using UnityEngine;

namespace Engine.Combat
{
    public class Fighter : MonoBehaviour, IAction
    {
        [SerializeField] float weaponRange = 1f;
        [SerializeField] float timeBetweenAttacks = 1f;
        [SerializeField] int weaponDamage = 5;
        private Transform target;
        private float _timeSinceLastAttack = 0;
        public void Update()
        {
            if (target == null || target.GetComponent<Health>().isDead)
            {
                Cancel();
                return;
            };
            _timeSinceLastAttack += Time.deltaTime;
            var mover = GetComponent<Mover>();
            var isInRange = Vector3.Distance(transform.position, target.position) < weaponRange;
            if (!isInRange)
            {
                mover.MoveTo(target.position);

            }
            else
            {
                mover.Cancel();
                HandleAttackBehaviour();
            }
        }
        public void Attack(CombatTarget combatTarget)
        {
            GetComponent<ActionScheduler>().StartAction(this);
            target = combatTarget.transform;
        }

        public void Cancel()
        {
            target = null;
        }

        // Animation Event
        void Hit()
        {
            
            target.GetComponent<Health>().TakeDamage(weaponDamage);
        }

        void HandleAttackBehaviour()
        {
            if (target.GetComponent<Health>().isDead) return;
            transform.LookAt(target.transform);
            if (_timeSinceLastAttack >= timeBetweenAttacks)
            {
                GetComponent<Animator>().SetTrigger("attack");
                _timeSinceLastAttack = 0f;
            }
        }
    }
}
