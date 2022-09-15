using Assets.Scripts.Combat;
using Assets.Scripts.Core;
using Assets.Scripts.Core.Character;
using UnityEngine;
using UnityEngine.AI;

namespace Engine.Movement
{
    public class Mover : MonoBehaviour, IAction
    {
        // Start is called before the first frame update

        [SerializeField] Transform target;
        private NavMeshAgent _navMeshAgent;

        void Start()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();
            _navMeshAgent.speed = GetComponent<Character>()?.Movement() ?? _navMeshAgent.speed;
        }

        void Update()
        {
            _navMeshAgent.enabled = !GetComponent<Health>().isDead;
            UpdateAnimator();
        }

        public void StartMoveAction(Vector3 destination)
        {
            GetComponent<ActionScheduler>().StartAction(this);
            MoveTo(destination);
        }
        public void MoveTo(Vector3 point)
        {
            
            _navMeshAgent.destination = point;
            _navMeshAgent.isStopped = false;
        }

        public float DistanceFromTarget()
        {
            return _navMeshAgent.remainingDistance;
        }
        public void Cancel()
        {
            _navMeshAgent.isStopped = true;
        }

        private void UpdateAnimator()
        {
            Vector3 velocity = _navMeshAgent.velocity;
            Vector3 localVelocity = transform.InverseTransformDirection(velocity);
            float speed = localVelocity.z;
            GetComponent<Animator>().SetFloat("forwardSpeed", speed);
        }
    }
}