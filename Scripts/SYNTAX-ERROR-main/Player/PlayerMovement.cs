using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 playerMovement;
    public float playerSpeed;
    public float speedReference;
    private Rigidbody2D myBody;
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        speedReference = playerSpeed;
        myBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void Move()
    {
        playerMovement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        myBody.velocity = playerSpeed*playerMovement;     
    }
    public void AnimateMovement()
    {
        animator.SetFloat("Speed", myBody.velocity.sqrMagnitude);
        if(playerMovement.x < 0)
        {
        spriteRenderer.flipX = true;
        }
        else if(playerMovement.x > 0)
        {
            spriteRenderer.flipX = false;
        }
    }
}