using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cainos.PixelArtTopDown_Basic;

public class Player_Medkit : Player_
{
    public float timer;
    public float medkit_timer;
    public float Medkit_cooldown;
    public bool isMedkit;
    void Update()
    {
        cooldown_control();
        Heal();
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