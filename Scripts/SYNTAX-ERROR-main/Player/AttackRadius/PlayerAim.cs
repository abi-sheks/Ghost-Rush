using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    
    private Vector3 mouseCoords;
    private GetDirection getLookDirection;
    void Start()
    {
        
        getLookDirection = GameObject.Find("DirectionGetter").GetComponent<GetDirection>();
    }
    public void Aim()
    {
        Transform attackOrigin = transform.GetChild(0);
        Vector2 lookDir = getLookDirection.GetLookDirection(attackOrigin);
        attackOrigin.eulerAngles = new Vector3(0f, 0f, Vector3.SignedAngle(Vector3.right, lookDir, Vector3.forward));
    }
    
}