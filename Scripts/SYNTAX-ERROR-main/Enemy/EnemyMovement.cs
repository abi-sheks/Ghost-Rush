using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour, IEnemyMovement
{
    // Start is called before the first frame update
    private Rigidbody2D myBody;
    private Animator animator;
    private Transform playerPos;
    private TimeTracker timeTracker;
    public float enemySpeed = 5f;
    private SpriteRenderer spriteRenderer;
    public float speedReference;
    void Start()
    {
        speedReference = enemySpeed;
        playerPos = GameObject.FindWithTag("Player").transform;
        myBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        timeTracker = GameObject.Find("Logic").GetComponent<TimeTracker>();
    }
    public void Move(Vector3 direction)
    {
        if(timeTracker.inGame)
        {
            enemySpeed = speedReference;
        }
        else 
        {
            enemySpeed = 0f;
        }
        myBody.transform.position += direction*enemySpeed*Time.deltaTime;
        
    }
    public void MoveAnimation()
    {
        return;
    }
}
