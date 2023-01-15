using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Image healthBar;

    public float currentHealth;

    private float maxHealth;

    PlayerHealth player;

    public GameObject healthPercent;
    
    void Start()
    {
        healthBar= GetComponent<Image>();
        player = FindObjectOfType<PlayerHealth>();
    }

    
    void Update()
    {
        currentHealth = player.currentPlayerHP;
        maxHealth= player.maxPlayerHP;
        healthBar.fillAmount = currentHealth / maxHealth ;

        healthPercent.GetComponent<Text>().text = ((int)(healthBar.fillAmount * 100)).ToString() + "%";

    }
}
