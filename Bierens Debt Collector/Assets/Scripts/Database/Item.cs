using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public string itemNr { get; set; }
    public string name { get; set; }
    public string quantity { get; set; }
    public string details { get; set; }

    public Item()
    {

    }
    public Item(string itemNr, string name, string quantity, string details)
    {
        this.itemNr = itemNr;
        this.name = name;
        this.quantity = quantity;
        this.details = details;
    }

}
