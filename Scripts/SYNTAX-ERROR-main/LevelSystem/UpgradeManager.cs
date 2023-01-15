using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    private PlayerAttack playerAttack;
    private PlayerHealth playerHealth;
    private PlayerMovement playerMovement;
    private LevelManager levelManager;
    public float addedStrength;
    public float addedHealth;
    public float addedSpeed;   
    void Start()
    {
        playerHealth = GetComponentInParent<PlayerHealth>();
        playerAttack = GameObject.Find("AttackPoint").GetComponent<PlayerAttack>();
        playerMovement = GetComponentInParent<PlayerMovement>();
        levelManager = GameObject.Find("XPPickupCheck").GetComponent<LevelManager>();
    }
    public void BuffHealth()
    {
        playerHealth.maxPlayerHP += addedHealth;
        playerHealth.currentPlayerHP = playerHealth.maxPlayerHP;
        addedHealth /= 2;

    }
    public void BuffStrength()
    {
        playerAttack.attackStrength += addedStrength;
        if(addedStrength > 1)
        addedStrength -= 0.5f;
        else addedStrength = 1;
    }
    public void BuffSpeed()
    {
        playerMovement.playerSpeed += addedSpeed;
        addedSpeed /= levelManager.playerLevel;
    }
}