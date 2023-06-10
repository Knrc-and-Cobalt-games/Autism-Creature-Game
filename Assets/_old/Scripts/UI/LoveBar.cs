using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoveBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxLoveness(float love)
    {
        slider.maxValue = love;
        slider.value = love;

    }

    public void SetLoveness(float love)
    {
        slider.value = love;
    }
}
