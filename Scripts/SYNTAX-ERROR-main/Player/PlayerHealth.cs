using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour, IDamage
{
    public float maxPlayerHP;
    public float currentPlayerHP;
    public bool isInvincible = false;
    public bool isHit = false;
    public bool isDead = false;
    [SerializeField]
    private float interval;
    private Rigidbody2D myBody;
    private Collider2D myCollider;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();   
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void TakeDamage(float attackStrength)
    {
        StartCoroutine(TakeHit(interval));
        if(attackStrength > currentPlayerHP)
        {
            currentPlayerHP = 0;
            Die();
        }   
        else currentPlayerHP -= attackStrength;
    }
    public void Die()
    {
        isDead = true;
        myCollider.enabled = false;
        Destroy(gameObject);
        myBody.gravityScale = 5f;
        SceneManager.LoadScene(1);

    }
    IEnumerator TakeHit(float interval)
    {
        isHit = true;
        isInvincible = true;
        animator.SetBool("isHit", isHit);
        yield return new WaitForSeconds(interval);
        isHit = false;
        isInvincible = false;
        animator.SetBool("isHit", isHit);
    }
}
