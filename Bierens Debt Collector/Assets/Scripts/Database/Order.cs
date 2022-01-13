using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order : MonoBehaviour
{
    public List<Item> items;

    public string orderNr { get; set; }
    public string company { get; set; }
    public string address { get; set; }
    public string city { get; set; }
    public string zip { get; set; }
    public string province { get; set; }
    public string country { get; set; }
    public string email { get; set; }
    public string phone { get; set; }
    public string dateOrdered { get; set; }
    public string shipment { get; set; }
    public string payment { get; set; }

    public Order()
    {

    }
       
}
