using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{

    public Slider slider;

    public void SetMaxStatus(float energyPoints)
    {
        slider.maxValue = energyPoints;
        slider.value = energyPoints;
    }

    public void SetHealth(float energyPoints)
    {
        slider.value = energyPoints;
    }
}
