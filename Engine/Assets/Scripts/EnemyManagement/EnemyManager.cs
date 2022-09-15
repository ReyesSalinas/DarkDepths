using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Engine.Controller
{
    public class EnemyManager : MonoBehaviour
    {
        IEnumerable enemyObjects;
        const string ENEMY_TAG = "Enemy";
        void Start()
        {
            enemyObjects = GameObject.FindGameObjectsWithTag(ENEMY_TAG);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

