using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerAttack : MonoBehaviour
{
    public bool isAttack;
    public float attackStrength;
    private Animator animator;

    private AudioSource swishSound;
    void Start()
    {
        animator = GetComponent<Animator>();
        swishSound = GetComponentInParent<AudioSource>();
    }
    public void Attack()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(!isAttack)
            isAttack = true;
            swishSound.Play(0);
            //play attack animation and add StopAttack as an event to animation frame.
        }
        animator.SetBool("isAttack", isAttack);
    }
    public void StopAttack()
    {
        isAttack = false;
    }


}