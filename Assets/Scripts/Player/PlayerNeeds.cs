using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNeeds : MonoBehaviour
{
    #region Initialize Valuables
        public float maxEnergy = 100;
        public float maxSleep = 100;
        public float currentEnergy;
        public float currentSleep;
    #endregion

    #region Natrual decreasing things
        public const float hunger = 0.25f;
        public const float tireness = 0.1f;
    #endregion
    #region Initialize Bars
        public EnergyBar EnergyBar;
        public SleepBar SleepBar;
    #endregion





    // Start is called before the first frame update
    void Start()
    {
        currentEnergy = maxEnergy;
        currentSleep = maxSleep;        
    }

    // Update is called once per frame
    void Update()
    {
        currentEnergy -= hunger * Time.deltaTime;
        currentSleep -= tireness * Time.deltaTime;

        EnergyBar.SetEnergy(currentEnergy);
        SleepBar.SetSleep(currentSleep);    


    }
}
