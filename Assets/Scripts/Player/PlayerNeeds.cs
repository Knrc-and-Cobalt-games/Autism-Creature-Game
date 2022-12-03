using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNeeds : MonoBehaviour
{
    #region Initialize Valuables
    [Header("Maximum Values for Needs")]
        public float maxEnergy = 100;
        public float maxSleep = 100;
        public float maxPoopie = 100;
        public float maxHappiness = 100;
        public float maxCleanness = 100;
        [Space]
        public float currentEnergy;
        public float currentSleep;
        public float currentPoopie;
        public float currentHappiness;
        public float currentCleanness;
        public float currentLove;
        [Space]
    #endregion

    #region Natrual decreasing things
    [Header("Natrual decreasing things")]
        public float hunger = 0.25f;
        public float tireness = 0.15f;
        public float toiletmeter = 0.4f;
        public float sadness = 0.1f;
        public float dirtiness = 0.3f;
        [Space]
    #endregion
    #region Initialize Bars
    [Header("Link Slider to each Bar")]
        public EnergyBar EnergyBar;
        public SleepBar SleepBar;
        public PoopBar PoopBar;
        public HappyBar HappyBar;
        public CleanBar CleanBar;
        public LoveBar LoveBar;
    #endregion





    // Start is called before the first frame update
    void Start()
    {
        currentEnergy = maxEnergy;
        currentSleep = maxSleep;    
        currentPoopie = maxPoopie;
        currentHappiness = maxHappiness;
        currentCleanness = maxCleanness;
    }

    // Update is called once per frame
    void Update()
    {
        currentEnergy -= hunger * Time.deltaTime;
        currentSleep -= tireness * Time.deltaTime;
        currentPoopie -= toiletmeter * Time.deltaTime;
        currentHappiness -= sadness * Time.deltaTime;
        currentCleanness -= dirtiness * Time.deltaTime;
        currentLove = currentEnergy + currentSleep + currentPoopie + currentHappiness + currentCleanness;

        if(currentEnergy <= 0)
        {
            currentEnergy = 0;
        }
        
        if(currentSleep <= 0)
        {
            currentSleep = 0;
        }
        
        if(currentPoopie <= 0)
        {
            currentPoopie = 0;
        }
        
        if(currentHappiness <= 0)
        {
            currentHappiness = 0;
        }
        
        if(currentCleanness <= 0)
        {
            currentCleanness = 0;
        }
    

        EnergyBar.SetEnergy(currentEnergy);
        SleepBar.SetSleep(currentSleep); 
        PoopBar.SetPoopie(currentPoopie);
        HappyBar.SetHappiness(currentHappiness);
        CleanBar.SetCleanness(currentCleanness);
        LoveBar.SetLoveness(currentLove);   


    }
}
