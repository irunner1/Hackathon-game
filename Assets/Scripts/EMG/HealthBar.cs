using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Player_ playerHealth;

    private void Start()
    {
        SetMaxHealth(playerHealth.maxHealth);
    }

    private void Update()
    {
        SetHealth(playerHealth.health);
    }

    public void SetMaxHealth(float health)
    {
        slider.maxValue = health;
    }

    public void SetHealth(float health)
    {
        slider.value = health;
    }
}

