using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RowDisplay : MonoBehaviour
{
    public Order orderScriptable;

    public Text rowOrdernr;
    public Text rowDate;
    public Text rowCompany;
    public Text rowShipment;
    public Text rowPayment;

    public Text detailOrderNr;
    public Text detailCompany;
    public Text detailAddress;
    public Text detailCity;
    public Text detailZip;
    public Text detailProvince;
    public Text detailCountry;
    public Text detailEmail;
    public Text detailPhone;
    public Text detailDateOrdered;
    public Text detailShipment;
    public Text detailPayment;

    void Start()
    {

    }

    public void createRow()
    {
        rowOrdernr.text = orderScriptable.orderNr;
        rowDate.text = orderScriptable.dateOrdered;
        rowCompany.text = orderScriptable.company;
        rowShipment.text = orderScriptable.shipment;
        rowPayment.text = orderScriptable.payment;
    }

    public void showOrderDetails(GameObject window)
    {
        Debug.Log("Ja hij komt hiero");
        window.SetActive(true);
        
        detailOrderNr.text = orderScriptable.orderNr;
        detailCompany.text = orderScriptable.company;
        detailAddress.text = orderScriptable.address;
        detailCity.text = orderScriptable.city;
        detailZip.text = orderScriptable.zip;
        detailProvince.text = orderScriptable.province;
        detailCountry.text = orderScriptable.country;
        detailEmail.text = orderScriptable.email;
        detailPhone.text = orderScriptable.phone;
        detailDateOrdered.text = orderScriptable.dateOrdered;
        detailShipment.text = orderScriptable.shipment;
        detailPayment.text = orderScriptable.payment;
        
    }
}
