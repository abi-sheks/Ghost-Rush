using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public Text timerText;

    private TimeTracker timeTracker;

    public void Start()
    {
         timeTracker = GameObject.Find("Logic").GetComponent<TimeTracker>();
    }
    
    public void update()
    {
        timerText.GetComponent<Text>().text = "Time Left : " + (120 - timeTracker.GetComponent<TimeTracker>().timeElapsed).ToString();
    }
}
