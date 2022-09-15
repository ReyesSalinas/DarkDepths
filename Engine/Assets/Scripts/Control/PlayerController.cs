using Assets.Scripts.Core.Character;
using Engine.Combat;
using Engine.Core;
using System;
using UnityEngine;

namespace Engine.Controller
{
    public class PlayerController : MonoBehaviour
    {
        private bool _isInCombat = false;
        private bool _canMoveToPoint = false;
        private EnemyTarget currentTarget = null;
        public delegate void HandleTarget(GameObject target);
        public HandleTarget onTargetHover;

        void Update()
        {
            if(GetComponent<Health>().isDead) return;
            HandleCombat();
            if (_isInCombat) return;
            HandleMovement();
        }

        private void HandleCombat()
        {
            var rayCastHits = Physics.RaycastAll(GetMouseRay());
            foreach (var hit in rayCastHits)
            {
                var combatTarget = hit.transform.GetComponent<EnemyTarget>();
               
                if (Input.GetMouseButtonDown(0))
                {
                    if (combatTarget == null)
                    {
                        _isInCombat = false;
                        continue;
                    }
                    currentTarget = combatTarget;
                    var fighter = GetComponent<Fighter>();
                    fighter.Attack(currentTarget);                    
                    _isInCombat = true;
                }
                onTargetHover(combatTarget?.gameObject);
            }
        }

        private void HandleMovement()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            var hasHit = Physics.Raycast(ray, out hit);
            if (hasHit)
            {
                var mover = GetComponent<Movement.Mover>();
                if (Input.GetMouseButton(0))
                {
                    mover.StartMoveAction(hit.point);
                    _isInCombat = false;
                }
                _canMoveToPoint = true;
            }
            else
            {
                _canMoveToPoint = false;
            }
            
        }

        private Ray GetMouseRay()
        {
            return Camera.main.ScreenPointToRay(Input.mousePosition);
        }
    }
}