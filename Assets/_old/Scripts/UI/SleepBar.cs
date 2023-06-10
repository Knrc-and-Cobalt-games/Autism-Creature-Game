using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SleepBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxSleep(float sleepy)
    {
        slider.maxValue = sleepy;
        slider.value = sleepy;

    }

    public void SetSleep(float sleepy)
    {
        slider.value = sleepy;
    }
}
