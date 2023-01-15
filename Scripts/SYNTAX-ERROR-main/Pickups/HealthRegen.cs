using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthRegen : MonoBehaviour,IApplyBuff
{
    PlayerHealth playerHealth;

    public float additionalHealth = 5f;

    public void Start()
    {
        playerHealth= GameObject.FindWithTag("Player").GetComponent<PlayerHealth>();
    }
    public void ApplyBuff()
    {
        if (playerHealth.maxPlayerHP - playerHealth.currentPlayerHP > additionalHealth)
        {
            playerHealth.currentPlayerHP += additionalHealth;
        }

        else
        {
            playerHealth.currentPlayerHP = playerHealth.maxPlayerHP;
        }
    }

    public void RemoveBuff()
    {
        return;
    }
}
