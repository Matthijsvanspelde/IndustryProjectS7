using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDisplay : MonoBehaviour
{
    public Item itemScriptable;

    public Text itemNr;
    public Text itemName;
    public Text quantity;
    public Text details;

    void Start()
    {
        itemNr.text = itemScriptable.itemNr;
        itemName.text = itemScriptable.itemName;
        quantity.text = itemScriptable.quantity;
        details.text = itemScriptable.details;
    }
}
