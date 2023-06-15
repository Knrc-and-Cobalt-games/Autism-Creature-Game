using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public Player player;
    public ShopItemSO[] shopItemsSO;
    public GameObject[] shopPanelsGO;
    public ShopTemplate[] shopPanels;
    public Button[] myPurchaseButtons;


private void Start() {

    for(int i = 0; i <shopItemsSO.Length; i++)
    shopPanelsGO[i].SetActive(true);
    LoadPanels();
    CheckPurchaseable();
}



public void LoadPanels()
{
    for(int i = 0; i <shopItemsSO.Length; i++)
    {
        shopPanels[i].itemNameTxt.text = shopItemsSO[i].itemName;
        shopPanels[i].itemSprite.sprite = shopItemsSO[i].itemSprite;
        shopPanels[i].costTxt.text = shopItemsSO[i].cost.ToString();
    }
}

public void CheckPurchaseable()
{
    for (int i = 0; i < shopItemsSO.Length; i++)
    {
        if (player.coins >= shopItemsSO[i].cost)
            myPurchaseButtons[i].interactable = true;
        else
            myPurchaseButtons[i].interactable = false;
    }
}

public void PurchaseItem(int buttonNumber)
{
    if(player.coins >= shopItemsSO[buttonNumber].cost)
    {
        player.coins = player.coins - shopItemsSO[buttonNumber].cost;
        CheckPurchaseable();
        player.CoinDisplayManager();
        //Unlock the item
    }
}


}
