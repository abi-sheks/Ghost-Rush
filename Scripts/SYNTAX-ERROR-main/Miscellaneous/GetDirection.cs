using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDirection : MonoBehaviour
{
    // Start is called before the first frame update
    private Camera mainCamera;
    void Start()
    {
        mainCamera = GameObject.Find("MainCamera").GetComponent<Camera>();
    }
    public Vector2 GetLookDirection(Transform transform)
    {
        Vector2 lookDir = mainCamera.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        return lookDir;
    }
}
