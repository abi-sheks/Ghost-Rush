using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupManager : MonoBehaviour
{
    private HealthRegen healthRegen;
    private Invincibility invincibility;
    private Freeze freeze;
    private string HEALTH_REGEN = "Health";
    private string INVINCIBILITY = "Invincibility";
    private string FREEZE = "Freeze";


    public float duration = 10f;
    void Start()
    {
        healthRegen= GameObject.Find("BuffHolder").GetComponent<HealthRegen>();
        invincibility= GameObject.Find("BuffHolder").GetComponent<Invincibility>();
        freeze= GameObject.Find("BuffHolder").GetComponent<Freeze>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(HEALTH_REGEN))
        {
            Destroy(collision.gameObject);
            StartCoroutine(PickupHealthRegen());
        }

        if (collision.gameObject.CompareTag(INVINCIBILITY))
        {
            Destroy(collision.gameObject);
            StartCoroutine(PickupInvincibility());
        }

        if(collision.gameObject.CompareTag(FREEZE))
        {
            Destroy(collision.gameObject);
            StartCoroutine(PickupFreeze());
        }
    }

    IEnumerator PickupHealthRegen()
    {


        healthRegen.ApplyBuff();

        yield return new WaitForSeconds(duration);

        healthRegen.RemoveBuff ();

     
    }

    IEnumerator PickupInvincibility()
    {
        

        invincibility.ApplyBuff();

        yield return new WaitForSeconds(duration - 5f);

        invincibility.RemoveBuff ();



    }

    IEnumerator PickupFreeze()
    {
        

        freeze.ApplyBuff();

        yield return new WaitForSeconds(duration);

        freeze.RemoveBuff ();

       

    }


}
