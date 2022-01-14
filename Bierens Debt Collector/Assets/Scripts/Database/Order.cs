using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Order", menuName = "ScriptableObjects/OrderScriptable")]
public class Order : ScriptableObject
{
    public string orderNr;
    public string company;
    public string address;
    public string city;
    public string zip;
    public string province;
    public string country;
    public string email;
    public string phone;
    public string dateOrdered;
    public string shipment;
    public string payment;

    public GameObject detailWindow;

    public List<Item> items;
}
