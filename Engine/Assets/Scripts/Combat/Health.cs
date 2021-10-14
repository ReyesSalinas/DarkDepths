using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
namespace Assets.Scripts.Combat
{
    public class Health : MonoBehaviour
    {
        [SerializeField] int amount = 100;
        public bool isDead = false;

        public void TakeDamage(int damage)
        {
            if(isDead)return;
            amount = Mathf.Max(amount - damage, 0);
            if (amount == 0)
            {
                GetComponent<Animator>().SetTrigger("die");
                isDead = true;
            }
            print(amount);
        }
    }
}
