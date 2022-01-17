using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class RowDisplay : MonoBehaviour
{
    public Order orderScriptable;

    public Text rowOrdernr;
    public Text rowDate;
    public Text rowCompany;
    public Text rowShipment;
    public Text rowPayment;
    public Button button;

    void Start()
    {
        rowOrdernr.text = orderScriptable.orderNr;
        rowDate.text = orderScriptable.dateOrdered;
        rowCompany.text = orderScriptable.company;
        rowShipment.text = orderScriptable.shipment;
        rowPayment.text = orderScriptable.payment;

    }

    public void Setbutton(DatabaseController action)
    {
        button.onClick.AddListener(delegate { action.openOrderDetails(this.gameObject); });
    }
    
}
