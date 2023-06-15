using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Food Item", menuName = "Item/Food Item")]
public class FoodObject : ItemObject
{
    public float energy;
    public float happiness;
    public float poopieness;
    public void awake()
    {
        type = ItemType.Food;
    }
}
