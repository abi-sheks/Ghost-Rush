using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IDamage 
{
    public void TakeDamage(float attackStrength);
    public void Die();
}