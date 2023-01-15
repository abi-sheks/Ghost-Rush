using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 currentPos;

    private Transform player;

    private string PLAYER_TAG = "Player";

    void Start()
    {
        player = GameObject.FindWithTag(PLAYER_TAG).transform;
    }

    
    void Update()
    {
        currentPos = transform.position;
        currentPos.x = player.position.x;
        currentPos.y = player.position.y;

        transform.position = currentPos;
    }
}
