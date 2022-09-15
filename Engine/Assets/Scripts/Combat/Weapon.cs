using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Combat
{
    [CreateAssetMenu(fileName = "Weapon", menuName = "Weapon/Make New Weapon", order = 0)]
    public class Weapon : ScriptableObject
    {
        [SerializeField] AnimatorOverrideController animatorOverride = null;
        [SerializeField] GameObject equippedPrefab = null;
        [SerializeField] private float weaponRange = 1f;
        [SerializeField] private float weaponDamage = 0;

        public float WeaponRange => weaponRange;

        public float WeaponDamage => weaponDamage;

        public void Spawn(Transform handTransform, Animator animator)
        {
            
            if(equippedPrefab != null)
            {
                Instantiate(equippedPrefab, handTransform);
            }

            if (animatorOverride != null)
            { 
                animator.runtimeAnimatorController = animatorOverride;
            }
            
        }

    }
}

