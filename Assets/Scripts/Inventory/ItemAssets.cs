using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    public static ItemAssets Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public Sprite CanSprite;
    public Sprite ChickenSprite;
    public Sprite HotChocolateSprite;
    public Sprite JuiceSprite;
    public Sprite SaladSprite;
    public Sprite ShrimpSprite;
    public Sprite ToastSprite;
    public Sprite TwonaSprite;
    public Sprite WhatSprite;
}
