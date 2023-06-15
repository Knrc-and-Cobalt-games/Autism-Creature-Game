using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Default Item", menuName = "Item/Default Item")]
public class DefaultObject : ItemObject
{

private void Awake() {
    type = ItemType.Default;
}
}
