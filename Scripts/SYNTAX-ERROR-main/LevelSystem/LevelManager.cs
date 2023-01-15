using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    private string XP_TAG = "XP";
    [SerializeField]
    public int playerLevel = 1;
    private TimeTracker timeTracker;
    [SerializeField]
    private Canvas upgradeUI;
    public int requiredXP = 100;
    [SerializeField]
    public int currentXP = 0;
    void Start()
    {
        timeTracker = GameObject.Find("Logic").GetComponent<TimeTracker>();
    }
   
    public void LevelUp()
    {
        playerLevel++;
        upgradeUI.gameObject.SetActive(true);
        timeTracker.inGame = false;

        //logic to load upgrade ui over the scene. upgrades handled by buttons mapped to buff scripts.
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == XP_TAG)
        {
            currentXP += other.gameObject.GetComponent<XPProperties>().xpValue;
            if(currentXP > requiredXP)
            {
                LevelUp();
                currentXP -= requiredXP;
                requiredXP += 50;
            }
            Destroy(other.gameObject);
        }
    }
}