using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cainos.PixelArtTopDown_Basic;

public class Player_Dash : Player_
{
    public float Dash_cooldown;
    public bool isDash;

    void Update()
    {
        cooldown_control();
        Dash();
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