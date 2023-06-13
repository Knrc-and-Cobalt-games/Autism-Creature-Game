using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HappinessBar : MonoBehaviour
{

    public Slider slider;

    public void SetMaxStatus(float happyPoints)
    {
        slider.maxValue = happyPoints;
        slider.value = happyPoints;
    }

    public void SetStatus(float happyPoints)
    {
        slider.value = happyPoints;
    }
}
