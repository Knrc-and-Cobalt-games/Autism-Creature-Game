using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    [Header("Capitalism")]
    public int coins;
    public int passiveIncomeCoins;
    public float passiveIncomeTimer;
    private float defaultPassiveIncomeTimer;
    [SerializeField] private ShopManager shopmanager;
    public TMP_Text coinUI;
    [Header("Status Variables")]
    public float lovePoints;
    public float energyPoints = 100f;
    public float cleanPoints = 100f;
    public float sleepPoints = 100f;
    public float poopiePoints = 100f;
    public float happyPoints = 100f;

    private float _lpCalc;

    [Header("Status Drain")]
    public float energyDrain;
    public float cleanDrain;
    public float sleepDrain;
    public float poopieDrain;
    public float happyDrain;

    [Header("Slider")]
    [SerializeField] private LoveBar _loveBar;
    [SerializeField] private EnergyBar _energyBar;
    [SerializeField] private CleannessBar _cleannessBar;
    [SerializeField] private SleepBar _sleepBar;
    [SerializeField] private PoopieBar _poopieBar;
    [SerializeField] private HappinessBar _happinessBar;



    // Start is called before the first frame update
    void Start()
    {
        CoinDisplayManager();
        defaultPassiveIncomeTimer = passiveIncomeTimer;
    }

    // Update is called once per frame
    void Update()
    {
        LovePointsCalculate();
        StatusDrain();
        AddPassiveCoins();

        _loveBar.SetStatus(lovePoints);
        _cleannessBar.SetStatus(cleanPoints);
        _energyBar.SetStatus(energyPoints);
        
    }

    private void LovePointsCalculate()
    {
        _lpCalc = (energyPoints + cleanPoints + sleepPoints + poopiePoints + happyPoints) /5;
        lovePoints = _lpCalc;
    }

    private void StatusDrain()
    {
        //Energy Point Drainage
        if(energyPoints > 0f)
        {
            energyPoints -= energyDrain * Time.deltaTime;
        } else if (energyPoints <= 0f)
        {
            energyPoints = 0f;
        }
        //Cleaness Point Drainage
        if(cleanPoints > 0f)
        {
            cleanPoints -= cleanDrain * Time.deltaTime;
        } else if (cleanPoints <= 0f)
        {
            cleanPoints = 0f;
        }
        //Sleep Point Drainage
        if(sleepPoints > 0f)
        {
            sleepPoints -= sleepDrain * Time.deltaTime;
        } else if (sleepPoints <= 0f)
        {
            sleepPoints = 0f;
        }
        //Poopie Point Drainage
        if(poopiePoints > 0f)
        {
            poopiePoints -= poopieDrain * Time.deltaTime;
        } else if (poopiePoints <= 0f)
        {
            poopiePoints = 0f;
        }
        //Happiness Point Drainage
        if(happyPoints > 0f)
        {
            happyPoints -= happyDrain * Time.deltaTime;
        } else if (happyPoints <= 0f)
        {
            happyPoints = 0f;
        }
    }

    public void CoinDisplayManager()
    {
        coinUI.text = "Coins: " + coins.ToString();
    }

    public void AddPassiveCoins()
    {
        passiveIncomeTimer -= Time.deltaTime;
        if(passiveIncomeTimer <= 0)
        {
            coins += passiveIncomeCoins;
            passiveIncomeTimer = defaultPassiveIncomeTimer;
            CoinDisplayManager();
            shopmanager.CheckPurchaseable();
        }
    }
}
