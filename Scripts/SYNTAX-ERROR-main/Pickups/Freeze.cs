using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Freeze : MonoBehaviour, IApplyBuff
{
    private Vector2 playerPos;
    private GameObject[] enemyPos;
    public float killRadius = 100f;
    EnemyMovement enemyMovement;
    
    void Start()
    {
        
        
    }
    
    public void ApplyBuff()
    {
        playerPos = GameObject.FindWithTag("Player").transform.position;
        enemyPos = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemyPos == null)
        {
            return;
        }

        else
        {
            for (int i = 0; i < enemyPos.Length; i++)
            {
                if (Vector2.Distance(playerPos, enemyPos[i].transform.position) < killRadius)
                {
                    enemyMovement = enemyPos[i].GetComponent<EnemyMovement>();
                    enemyMovement.enemySpeed = 0f;
                }
            }
        }
    }

    public void RemoveBuff()
    {
        foreach(GameObject enemy in enemyPos)
        {
            EnemyMovement temp = enemy.GetComponent<EnemyMovement>();
            temp.enemySpeed = temp.speedReference;
        }
        return;
    }
}