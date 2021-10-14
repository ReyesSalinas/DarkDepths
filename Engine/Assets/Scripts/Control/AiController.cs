using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Core.Enums;
using UnityEngine;

namespace Engine.Controller
{
    public class AiController : MonoBehaviour
    {
        [SerializeField] float chaseDistance = 5f;

        // Update is called once per frame
        void Update()
        {
            var target = GameObject.FindGameObjectWithTag(GameObjectTags.Player.ToString());
            if (ShouldChase(target))
            {
                print($"{gameObject.name} should chase {target.name}");
            }
        }

        bool ShouldChase(GameObject target)
        {
            return DistanceToTarget(target.transform) < chaseDistance;
        }

        float DistanceToTarget(Transform target)
        {
            return Vector3.Distance(target.position, transform.position);
        } 
    }

}
