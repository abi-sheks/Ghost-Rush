using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

 public class TimeTracker : MonoBehaviour
{
    public float timeElapsed = 0f;
    public float winTime = 120f;
    public bool inGame;
    // Update is called once per frame
    void Start()
    {
        inGame = false;
    }
    void Update()
    {
        if (inGame){
            timeElapsed += Time.deltaTime; 
        }
        if(timeElapsed > winTime)
        {
            SceneManager.LoadScene(2);
        }
    }

 }
