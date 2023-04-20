using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cainos.PixelArtTopDown_Basic;

public class Player : MonoBehaviour
{
    [SerializeField] float health, maxHealth = 100f;
    public bool isMedkit;
    public float Medkit_cooldown;
    public float timer;
    void Start()
    {

        health = maxHealth;
    }

    void Update()
    {
        cooldown_control();
        Heal();
    }

    // Update is called once per frame
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

    public void Heal()
    {
        if (!isMedkit) { return; }
        if (Input.GetKeyUp(KeyCode.F))
        {
            timer = 0.0f;
            TopDownCharacterController.speed = 3.0f;
        }
        if (Input.GetKey(KeyCode.F) && health != maxHealth)
        {
            TopDownCharacterController.speed = 0.0f;
            timer += Time.deltaTime;
            if (timer >= 5.0f)
            {
                addHealth(50);
                timer = 0;
                isMedkit = false;
                Medkit_cooldown = 0.0f;
                TopDownCharacterController.speed = 3.0f;
            }
        }
    }

    public void cooldown_control()
    {
        if (!isMedkit)
        {
            Medkit_cooldown += Time.deltaTime;
            if (Medkit_cooldown >= 20.0f)
            {
                isMedkit = true;
            }
        }
    }
}