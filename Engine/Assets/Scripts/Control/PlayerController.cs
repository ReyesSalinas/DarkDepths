using System.Collections;
using System.Collections.Generic;
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
            print("Nothing to do here");
        }

        private void HandleCombat()
        {
            ResetCombatState();
            var rayCastHits = Physics.RaycastAll(GetMouseRay());
            foreach (var hit in rayCastHits)
            {
                var combatTarget = hit.transform?.GetComponent<CombatTarget>();
                if (combatTarget == null) continue;
                if (Input.GetMouseButtonDown(0))
                {
                    GetComponent<Fighter>().Attack(combatTarget);
                }

                _isInCombat = true;
            }
        }

        private void HandleMovement()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            var hasHit = Physics.Raycast(ray, out hit);
            if (hasHit)
            {
                if (Input.GetMouseButton(0))
                {
                    GetComponent<Movement.Mover>().MoveTo(hit.point);
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

        private void ResetCombatState()
        {
            _isInCombat = false;
        }
    }
}