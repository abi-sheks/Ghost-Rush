using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private PlayerHealth playerHealth;
    private PlayerAttack playerAttack;
    private TimeTracker timeTracker;
    private PlayerAim playerAim;
    private Rigidbody2D myBody;
    private GameObject pauseMenu;
    private EnemyHealth enemyHealth;
    private string ENEMY_TAG = "Enemy";


    void Start()
    {
        pauseMenu = GameObject.Find("PauseMenu");
        playerMovement = GetComponent<PlayerMovement>();
        playerHealth = GetComponent<PlayerHealth>();
        playerAim = GetComponent<PlayerAim>();
        playerAttack = GetComponentInChildren<PlayerAttack>();
        timeTracker = GameObject.Find("Logic").GetComponent<TimeTracker>();
        myBody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(timeTracker.inGame)
        {
            if(Input.GetKeyDown(KeyCode.P))
            {
                timeTracker.inGame = false;
                pauseMenu.SetActive(true);

            }
            playerMovement.AnimateMovement();
            playerAttack.Attack();
            playerAim.Aim();
        }
        else
        {
            myBody.velocity = Vector2.zero;
        }
    }
    void FixedUpdate()
    {
        if(timeTracker.inGame)
        {
        playerMovement.Move();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == ENEMY_TAG && !playerHealth.isInvincible)
        {
            playerHealth.TakeDamage(EnemyHealth.enemyStrength);
        }
    }
}