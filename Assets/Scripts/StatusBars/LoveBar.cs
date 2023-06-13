using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoveBar : MonoBehaviour
{

    public Slider slider;

    public void SetMaxStatus(float lovePoints)
    {
        slider.maxValue = lovePoints;
        slider.value = lovePoints;
    }

    public void SetStatus(float lovePoints)
    {
        slider.value = lovePoints;
    }
}
