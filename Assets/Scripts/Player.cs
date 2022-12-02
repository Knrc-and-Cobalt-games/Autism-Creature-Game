using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region Initialize Valuables
        public float maxEnergy = 100;
        public float maxSleep = 100;
        public float currentEnergy;
        public float currentSleep;
    #endregion

    #region Initialize Bars
        public EnergyBar EnergyBar;
        public SleepBar SleepBar;
    #endregion

    #region Natrual decreasing things
        private const float hunger = 0.25f;
        private const float tireness = 0.1f;
    #endregion

    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float accelerationTime = 2f;
    public float maxSpeed = 5f;
    private Vector2 movement;
    private float timeLeft;

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


        timeLeft -= Time.deltaTime;
        if(timeLeft <= 0)
        {
            movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            timeLeft += accelerationTime;
        }     
    }

    void FixedUpdate()
    {
        rb.AddForce(movement * maxSpeed);
    }
}
