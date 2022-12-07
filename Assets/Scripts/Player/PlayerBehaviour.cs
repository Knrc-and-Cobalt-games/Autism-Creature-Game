using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerDrainEnergy(0.1f);
        Debug.Log(GameManager.gameManager._PlayerStats.Energy);

    }

    private void PlayerDrainEnergy(float rmEnergy)
    {
        GameManager.gameManager._PlayerStats.DrainEnergy(rmEnergy);
    }    

    private void PlayerDrainSleep(float rmSleep)
    {
        GameManager.gameManager._PlayerStats.DrainSleep(rmSleep);
    }
    private void PlayerDrainPoopie(float rmPoopie)
    {
        GameManager.gameManager._PlayerStats.DrainPoopie(rmPoopie);
    }
    private void PlayerDrainHappiness(float rmHappiness)
    {
        GameManager.gameManager._PlayerStats.DrainHappiness(rmHappiness);
    }
    private void PlayerDrainCleanness(float rmCleanness)
    {
        GameManager.gameManager._PlayerStats.DrainCleanness(rmCleanness);
    }
    private void PlayerDrainLove(float rmLove)
    {
        GameManager.gameManager._PlayerStats.DrainLove(rmLove);
    }

    private void PlayerGainEnergy(float addEnergy)
    {
        GameManager.gameManager._PlayerStats.GainEnergy(addEnergy);
    }
    private void PlayerGainSleep(float addSleep)
    {
        GameManager.gameManager._PlayerStats.GainSleep(addSleep);
    }
    private void PlayerGainPoopie(float addPoopie)
    {
        GameManager.gameManager._PlayerStats.GainPoopie(addPoopie);
    }
    private void PlayerGainHappiness(float addHappiness)
    {
        GameManager.gameManager._PlayerStats.GainHappiness(addHappiness);
    }
    private void PlayerGainCleanness(float addCleanness)
    {
        GameManager.gameManager._PlayerStats.GainCleanness(addCleanness);
    }

}
