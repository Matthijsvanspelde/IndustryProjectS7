using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new item", menuName = "ScriptableObjects/ItemScriptable")]
public class Item : ScriptableObject
{
    public string itemNr;
    public string itemName;
    public string quantity;
    public string details;
}
