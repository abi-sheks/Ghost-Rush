using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPBar : MonoBehaviour
{
    private Image xpBar;

    private float currentXP;

    private float xpToHit;

    LevelManager player;

    public GameObject xpPercent;

    void Start()
    {
        xpBar = GetComponent<Image>();
        player = FindObjectOfType<LevelManager>();
    }


    void Update()
    {
        currentXP = player.currentXP;
        xpToHit = player.requiredXP;
        xpBar.fillAmount = currentXP / xpToHit ;

        xpPercent.GetComponent<Text>().text =((int)(xpBar.fillAmount * 100)).ToString() + "%";

    }
}
