using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{
    public enum ItemType {
        Shrimp,
        Juice,
        Can,
        Chicken,
        HotChocolate,
        Salad,
        Toast,
        Twona,
        What,
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch(itemType)
        {
            default:
            case ItemType.Shrimp:       return ItemAssets.Instance.ShrimpSprite;
            case ItemType.Juice:        return ItemAssets.Instance.JuiceSprite;
            case ItemType.Can:          return ItemAssets.Instance.CanSprite;
            case ItemType.Chicken:      return ItemAssets.Instance.ChickenSprite;
            case ItemType.HotChocolate: return ItemAssets.Instance.HotChocolateSprite;
            case ItemType.Salad:        return ItemAssets.Instance.SaladSprite;
            case ItemType.Toast:        return ItemAssets.Instance.ToastSprite;
            case ItemType.Twona:        return ItemAssets.Instance.TwonaSprite;
            case ItemType.What:         return ItemAssets.Instance.WhatSprite;
        }
    }

}

