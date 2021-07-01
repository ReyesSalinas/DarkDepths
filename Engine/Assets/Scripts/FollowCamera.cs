using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace Assets
{
    class FollowCamera : MonoBehaviour
    {
        [SerializeField] private Transform target;
        
        void Update()
        {
           transform.position = target.position;
        }
    }
}
