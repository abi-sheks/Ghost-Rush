using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Invincibility : MonoBehaviour
{

    PlayerHealth playerHealth;

    void Start()
    {
        playerHealth = GameObject.FindWithTag("Player").GetComponent<PlayerHealth>();
    }

    public void ApplyBuff()
    {
        playerHealth.isInvincible = true;
    }

    public void RemoveBuff()
    {
        playerHealth.isInvincible = false;
    }
}
