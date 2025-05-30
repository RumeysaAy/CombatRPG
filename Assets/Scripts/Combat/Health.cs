using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Combat
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private float healthPoints = 100f;
        bool isDeath = false;

        public bool IsDead()
        {
            return isDeath;
        }

        public void TakeDamage(float damage)
        {
            healthPoints = Mathf.Max(healthPoints - damage, 0);
            if (healthPoints == 0)
            {
                Die();
            }
            print(healthPoints);
        }

        private void Die()
        {
            if (isDeath) return;
            GetComponent<Animator>().SetTrigger("die");
            isDeath = true;
        }
    }
}
