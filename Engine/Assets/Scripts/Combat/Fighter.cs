using Assets.Scripts.Combat;
using Assets.Scripts.Core;
using Engine.Core;
using Engine.Movement;
using UnityEngine;
using Assets.Scripts.Core.Character;

namespace Engine.Combat
{
    public class Fighter : MonoBehaviour, IAction
    {
        [SerializeField] float timeBetweenAttacks = 1f;
        [SerializeField] Transform handTransform = null;
        [SerializeField] Weapon defaultWeapon = null;


        private Transform target;
        private float _timeSinceLastAttack = 0;
        private Weapon currentWeapon = null;
        public void Start()
        {
            EquipWeapon(defaultWeapon);
        }

        
        public void Update()
        {
            if (target == null || target.GetComponent<Health>().isDead)
            {
                Cancel();
                return;
            };
            _timeSinceLastAttack += Time.deltaTime;
            var mover = GetComponent<Mover>();
            var isInRange = Vector3.Distance(transform.position, target.position) < (currentWeapon?.WeaponRange ?? 1f);
            if (!isInRange & !IsInAttackAnimation(GetComponent<Animator>()))
            {
                mover.MoveTo(target.position);

            }
            else
            {
                mover.Cancel();
                HandleAttackBehaviour();
            }
        }
        public void Attack(Target combatTarget)
        {
            GetComponent<ActionScheduler>().StartAction(this);
            target = combatTarget.transform;
        }

        public void Cancel()
        {
            target = null;
        }

        // Animation Event
        void Hit()
        {
            var bonusDamage = GetComponent<Character>()?.Attack() ?? 0f; 
            var weaponDamage = currentWeapon?.WeaponDamage ?? 0f;           
            target.GetComponent<Health>().TakeDamage(bonusDamage + weaponDamage);
        }

        void HandleAttackBehaviour()
        {
            if (target.GetComponent<Health>().isDead) return;
            transform.LookAt(target.transform);
            if (_timeSinceLastAttack >= timeBetweenAttacks)
            {
                GetComponent<Animator>().SetTrigger("attack");
                _timeSinceLastAttack = 0f;
            }
        }

        bool IsInAttackAnimation(Animator animator)
        {
            return animator.GetCurrentAnimatorStateInfo(0).IsName("Attack");
        }
        public void EquipWeapon(Weapon weapon)
        {
            currentWeapon = weapon;
            Animator animator = GetComponent<Animator>();
            currentWeapon.Spawn(handTransform,animator);
        }
    }
}
