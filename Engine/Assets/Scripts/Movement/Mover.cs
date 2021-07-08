using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

namespace Engine.Movement
{
    public class Mover : MonoBehaviour
    {
        // Start is called before the first frame update

        [SerializeField] Transform target;

        void Update()
        {
            UpdateAnimator();
        }

        public void MoveTo(Vector3 point)
        {
            GetComponent<NavMeshAgent>().destination = point;
        }

        private void UpdateAnimator()
        {
            Vector3 velocity = GetComponent<NavMeshAgent>().velocity;
            Vector3 localVelocity = transform.InverseTransformDirection(velocity);
            float speed = localVelocity.z;
            GetComponent<Animator>().SetFloat("forwardSpeed", speed);
        }
    }
}