using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public int Health = 1;
    public UnitType UnitType;

    public virtual void TakeDamage(int x)
    {
        Health -= x;
        if (Health <= 0)
        {
            Die();
        }
    }
    public virtual void Die()
    {
        Destroy(gameObject);
    }
}

public enum UnitType 
{
    Player,
    Enemy,
    Object
}