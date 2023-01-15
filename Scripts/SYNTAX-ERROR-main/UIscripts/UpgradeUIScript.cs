using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeUIScript : MonoBehaviour
{
    private UpgradeManager upgradeManager;
    private TimeTracker timeTracker;
    private Text strengthText;
    private Text healthText;

    
    void Start(){
        upgradeManager = GameObject.Find("XPPickupCheck").GetComponent<UpgradeManager>();
        timeTracker= GameObject.Find("Logic").GetComponent<TimeTracker>();
        
        
    }
    public void UpgradeHealth()
    {
        timeTracker.inGame = true;
        upgradeManager.BuffHealth();
        gameObject.SetActive(false);
       
        
    }
    public void UpgradeStrength(){
        
        timeTracker.inGame = true;
        upgradeManager.BuffStrength();
        gameObject.SetActive(false);
      
    }
    // public void UpgradeSpeed(){
    //     upgradeManager.BuffSpeed();
    //     gameObject.SetActive(false);
    // }
}
