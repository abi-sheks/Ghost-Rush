using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropXP : MonoBehaviour
{
    [SerializeField]
    private GameObject xpObject;
    public void DropExperience()
    {
        Instantiate(xpObject, transform.position, Quaternion.identity);
    }
}