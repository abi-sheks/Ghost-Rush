using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropManager : MonoBehaviour
{
    
    [SerializeField] private GameObject droppedHealth;
    [SerializeField] private GameObject droppedInvinc;
    [SerializeField] private GameObject droppedFreeze;

    void Start()
    {
    }
    public void DropBuff()
    {
        int decider = (int)Random.Range(0, 100);
        if(decider > 10 && decider < 20)
        {
            Instantiate(droppedInvinc, transform.position, Quaternion.identity);
        }
        
        else if(decider > 30 && decider < 50)
        {
            Instantiate(droppedHealth, transform.position, Quaternion.identity);
        }
        
        else if(decider > 60 && decider < 65)
        {
            Instantiate(droppedFreeze, transform.position, Quaternion.identity);
        }
    } 
}