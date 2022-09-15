using System.Collections;
using System.Collections.Generic;
using Engine.Combat;
using UnityEngine;

namespace Assets.Scripts.Combat
{ 
    public class WeaponPickup : MonoBehaviour
    {
        [SerializeField] private Weapon weapon = null;

        private void OnTriggerEnter(Collider collider)
        {
            print("entered");
            if (collider.gameObject.tag == "Player")
            {
                collider.GetComponent<Fighter>().EquipWeapon(weapon);
                Destroy(gameObject);
            }
        }

    }
}
