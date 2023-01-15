using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAttack : MonoBehaviour
{
    private string ENEMY_TAG = "Enemy";
    private PlayerAttack playerAttack;
    private EnemyHealth enemyHealth;
    void Start()
    {
        playerAttack = GetComponentInParent<PlayerAttack>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == ENEMY_TAG && playerAttack.isAttack)
        {
            enemyHealth = other.gameObject.GetComponent<EnemyHealth>();
            enemyHealth.TakeDamage(playerAttack.attackStrength);
        }
    }
}