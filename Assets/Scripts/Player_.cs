using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cainos.PixelArtTopDown_Basic;

public class Player_ : MonoBehaviour
{
    [SerializeField] public float health, maxHealth = 100f;
    public float timer;
    public float medkit_timer;
    public float Medkit_cooldown;
    public float Dash_cooldown;
    public bool isMedkit;
    public bool isDash;
    public bool isKey;

    public int Block_amount = 0;

    void Start()
    {
        health = maxHealth;
    }

    void Update()
    {
        cooldown_control();
        Heal();
        Dash();
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
            medkit_timer = 0.0f;
            TopDownCharacterController.speed = 3.0f;
        }
        if (Input.GetKey(KeyCode.F) && health != maxHealth)
        {
            TopDownCharacterController.speed = 0.0f;
            medkit_timer += Time.deltaTime;
            if (medkit_timer >= 5.0f)
            {
                addHealth(50);
                medkit_timer = 0;
                isMedkit = false;
                Medkit_cooldown = 0.0f;
                TopDownCharacterController.speed = 3.0f;
            }
        }
    }

    public void Dash()
    {
        if (!isDash) { return; }
        if (Input.GetKeyDown(KeyCode.Q) && (gameObject.GetComponent<Rigidbody2D>().velocity.x != 0 || gameObject.GetComponent<Rigidbody2D>().velocity.y != 0))
        {
            TopDownCharacterController.speed = 75.0f;
            Invoke(nameof(dropSpeed), 0.0375f);
            Dash_cooldown = 0.0f;
            isDash = false;
        }
    }

    public void dropSpeed()
    {
        TopDownCharacterController.speed = 3.0f;
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

        if (!isDash)
        {
            Dash_cooldown += Time.deltaTime;
            if (Dash_cooldown >= 3.0f)
            {
                isDash = true;
            }
        }
    }

}