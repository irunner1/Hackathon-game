using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Slider slider;
    public Player_Medkit time;

    private void Start()
    {
        SetMaxTime(time.medkit_timer);
    }

    private void Update()
    {
        SetTime(time.medkit_timer);
    }

    public void SetMaxTime(float timer)
    {
        slider.maxValue = timer;
    }

    public void SetTime(float timer)
    {
        slider.value = timer;
    }
}

