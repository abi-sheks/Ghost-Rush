using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;
    bool coroutineCalled;
    [SerializeField]
    private float leftBound, rightBound, lowBound, highBound;
    private TimeTracker timeTracker;
    void Start()
    {
        timeTracker = GameObject.Find("Logic").GetComponent<TimeTracker>();
        StartCoroutine(SpawnEnemy(enemy));
        InvokeRepeating("CallAgain", 0f, 3f);
    }
    void CallAgain()
    {
        if(!coroutineCalled)
        {
            StartCoroutine(SpawnEnemy(enemy));
        }
    }
    private IEnumerator SpawnEnemy(GameObject enemy)
    {
        if(timeTracker.inGame)
        {
        yield return new WaitForSeconds((int)Random.Range(3, 5));
        Instantiate(enemy, new Vector3(Random.Range(leftBound, rightBound), Random.Range(lowBound, highBound)), Quaternion.identity);
        StartCoroutine(SpawnEnemy(enemy));
        coroutineCalled = true;
        }
        else coroutineCalled = false;
    }
}
