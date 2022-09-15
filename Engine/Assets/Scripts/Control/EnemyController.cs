using Assets.Scripts.Combat;
using Assets.Scripts.Core.Enums;
using Assets.Scripts.Core.Character;
using Engine.Combat;
using Engine.Core;
using Engine.Movement;
using UnityEngine;

namespace Engine.Controller
{
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] float chaseDistance = 5f;
        [SerializeField] int ExpierenceGiven;

        private Vector3 startingLocation;

        void Start()
        {
            startingLocation = GetComponent<EnemyTarget>().transform.position;
        }

        private PlayerTarget currentTarget;
        // Update is called once per frame
        void Update()
        {
            if (GetComponent<Health>().isDead) return;
            if (currentTarget)
            {
                HandleChase(currentTarget);
            }
            var target = GameObject.FindGameObjectWithTag(GameObjectTags.Player.ToString()).GetComponent<PlayerTarget>();
            HandleChase(target);

        }

        void HandleChase(PlayerTarget target)
        {
            var fighter = GetComponent<Fighter>();

            if (ShouldChase(target))
            {
                currentTarget = target;
                fighter.Attack(target.GetComponent<PlayerTarget>());
            }
            else
            {
                currentTarget = null;
                fighter.Cancel();
                if (GetComponent<EnemyTarget>().transform.position != startingLocation)
                {
                    GetComponent<Mover>().MoveTo(startingLocation);
                }
               
            }
        }


        bool ShouldChase(PlayerTarget target)
        {
            return DistanceToTarget(target.transform) < chaseDistance;
        }


        float DistanceToTarget(Transform target)
        {
            return Vector3.Distance(target.position, transform.position);
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawWireSphere(transform.position,chaseDistance);
        }

    }

}
