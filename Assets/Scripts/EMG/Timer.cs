using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Slider slider;
   public Player_ time;

   private void Start()
   {
        SetMaxTime(time.timer);
   }

   private void Update()
   {
        SetTime(time.timer);
   }

   public void SetMaxTime(float timer)
   {
        slider.maxValue = timer;
        slider.value  = timer;
   }

     public void SetTime(float timer)
   {
        slider.value  = timer;
   }
}

