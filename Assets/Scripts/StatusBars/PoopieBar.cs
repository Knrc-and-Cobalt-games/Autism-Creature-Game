using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoopieBar : MonoBehaviour
{

    public Slider slider;

    public void SetMaxStatus(float poopiePoints)
    {
        slider.maxValue = poopiePoints;
        slider.value = poopiePoints;
    }

    public void SetStatus(float poopiePoints)
    {
        slider.value = poopiePoints;
    }
}
