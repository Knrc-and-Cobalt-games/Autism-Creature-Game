using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SleepBar : MonoBehaviour
{

    public Slider slider;

    public void SetMaxStatus(float sleepPoints)
    {
        slider.maxValue = sleepPoints;
        slider.value = sleepPoints;
    }

    public void SetHealth(float sleepPoints)
    {
        slider.value = sleepPoints;
    }
}
