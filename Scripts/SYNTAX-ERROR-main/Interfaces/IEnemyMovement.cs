using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IEnemyMovement
{
    public void Move(Vector3 direction);
    public void MoveAnimation();
}
