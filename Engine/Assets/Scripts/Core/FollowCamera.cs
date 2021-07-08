using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace Engine.Core
{
    class FollowCamera : MonoBehaviour
    {
        [SerializeField] private Transform target;
        
        void LateUpdate()
        {
           transform.position = target.position;
        }
    }
}
