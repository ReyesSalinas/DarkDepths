using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Core;
using Engine.Combat;
using UnityEditor;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.AI;


namespace Engine.Controller
{
    public class PlayerController : MonoBehaviour
    {
        private bool _isInCombat = false;
        private bool _canMoveToPoint = false;

        void Update()
        {
            HandleCombat();
            if (_isInCombat) return;
            HandleMovement();
            if (_canMoveToPoint) return;
        }

        private void HandleCombat()
        {
            var rayCastHits = Physics.RaycastAll(GetMouseRay());
            foreach (var hit in rayCastHits)
            {
                var combatTarget = hit.transform?.GetComponent<CombatTarget>();
                if (Input.GetMouseButtonDown(0))
                {
                    var fighter = GetComponent<Fighter>();
                    if (combatTarget == null)
                    {
                        _isInCombat = false;
                        return;
                    }
                    fighter.Attack(combatTarget);
                    _isInCombat = true;
                    return;
                }
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