using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ShopMenu", menuName = "Shop/New Shop Item")]
public class ShopItemSO : ScriptableObject
{
    public string itemName;
    public Sprite itemSprite;
    public int cost;
    public ItemObject item;
}