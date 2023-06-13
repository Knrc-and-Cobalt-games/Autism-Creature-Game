using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CleannessBar : MonoBehaviour
{

    public Slider slider;

    public void SetMaxStatus(float cleanPoints)
    {
        slider.maxValue = cleanPoints;
        slider.value = cleanPoints;
    }

    public void SetHealth(float cleanPoints)
    {
        slider.value = cleanPoints;
    }
}
