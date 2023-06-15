using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Default,
    Food

}
public class ItemObject : ScriptableObject
{
    public string ItemName;
    public ItemType type;
    public Sprite itemAsset;
}
