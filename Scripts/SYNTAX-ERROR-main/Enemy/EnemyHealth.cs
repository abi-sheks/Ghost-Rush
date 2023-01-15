using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour, IDamage
{
    // Start is called before the first frame update
    [SerializeField]
    public float enemyHP;
    private Rigidbody2D myBody;
    private DropXP dropXP;
    private DropManager dropManager;
    public static float enemyStrength = 5;
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        dropXP = GetComponent<DropXP>();
        dropManager = GetComponent<DropManager>();
    }

    // Update is called once per frame
    public void TakeDamage(float attackStrength)
    {
        if(attackStrength > enemyHP)
        {
            enemyHP = 0;
            Die();
        }   
        else enemyHP -= attackStrength;
    }
    public void Die()
    {
        dropXP.DropExperience();
        dropManager.DropBuff();
        Destroy(transform.gameObject);
    }
   
}
