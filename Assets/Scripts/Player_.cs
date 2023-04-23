using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_ : MonoBehaviour
{
    public float health, maxHealth = 100f;
    public int Block_amount = 0;

    void Start()
    {
        health = maxHealth;
    }

    public void takeDamage(float damageAmount)
    {
        health -= damageAmount;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void addHealth(float healthAmount)
    {
        health += healthAmount;

        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }
}
