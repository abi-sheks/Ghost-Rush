using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyController : MonoBehaviour
{
    //Pathfinding implemented within controller itself
    // Start is called before the first frame update
    private EnemyMovement enemyMovement;
    private EnemyHealth enemyHealth;
    private Path path;
    private Seeker seeker;
    private Transform playerPos;
    private int currentWPIndex = 0;
    private float maxWPDistance = 0.03f;
    private TimeTracker timeTracker;
    //for reference
    private bool reachedEOP;

    void Start()
    {
        enemyHealth = GetComponent<EnemyHealth>();
        timeTracker = GameObject.Find("Logic").GetComponent<TimeTracker>();
        seeker = GetComponent<Seeker>();
        playerPos = GameObject.FindWithTag("Player").transform;
        enemyMovement = GetComponent<EnemyMovement>();
        InvokeRepeating("UpdatePath", 0f, 0.5f);
    }
    void UpdatePath()
    {
        if(seeker.IsDone())
        {
            seeker.StartPath(transform.position, playerPos.position, OnPathComplete);
        }
    }
    void OnPathComplete(Path pt)
    {
        if(!pt.error)
        {
            path = pt;
            currentWPIndex = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(path == null) return;
        if(currentWPIndex >= path.vectorPath.Count)
        {
            reachedEOP = true;
            return;
        }
        else
        {
            reachedEOP = false;
        }

        Vector3 direction = (path.vectorPath[currentWPIndex] - transform.position).normalized;
        enemyMovement.Move(direction);
        float currDistance = Vector3.Distance(transform.position, path.vectorPath[currentWPIndex]);
        if(currDistance < maxWPDistance)
        {
            currentWPIndex++;
        }
        if(timeTracker.timeElapsed > 30 && timeTracker.timeElapsed < 31)
        {
            enemyHealth.enemyHP += 5;
            EnemyHealth.enemyStrength += 3;
        }
    }
    IEnumerator BuffStats()
    {
        yield return new WaitForSeconds(30);
        enemyHealth.enemyHP += 2;
        EnemyHealth.enemyStrength += 3;
    }
}
   