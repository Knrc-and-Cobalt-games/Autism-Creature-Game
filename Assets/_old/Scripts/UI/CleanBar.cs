using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CleanBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxCleanness(float clean)
    {
        slider.maxValue = clean;
        slider.value = clean;

    }

    public void SetCleanness(float clean)
    {
        slider.value = clean;
    }
}
