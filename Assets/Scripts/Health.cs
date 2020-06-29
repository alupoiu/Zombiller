using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is attached to everything with health
public class Health : MonoBehaviour
{
    // health of entity
    public float health = 100f;

    // Enitity that holds health
    public GameObject entity;

    void Update()
    {
        // Kill entity when health is less than of equal to 0
        if (health <= 0)
        {
            Destroy(entity);
        }
    }
}
