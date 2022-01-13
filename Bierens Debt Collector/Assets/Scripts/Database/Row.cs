using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Row : MonoBehaviour
{
    //Row
    [SerializeField] TextMesh rowOrdernr, rowDate, rowCompany, rowOrdertxt, rowShipment, rowPayment;
    //Order Details
    [SerializeField] TextMesh detailsOrdernr, detailsCompany, detailsAddress, detailsCity, detailsZip, detailsProvince, detailsCountry, detailsEmail, detailsPhone, detailsDate, detailsShipment, detailsPayment;

    GameObject detailWindow;
    Order order;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void fillItemRow(Order order, GameObject window)
    {
        this.order = order;
        this.detailWindow = window;

        this.rowOrdernr.text = order.orderNr;
        this.rowDate.text = order.dateOrdered;
        this.rowCompany.text = order.company;
        this.rowShipment.text = order.shipment;
        this.rowPayment.text = order.payment;
    }

    public void fillOrderDetails()
    {
        detailWindow.SetActive(true);

        this.detailsOrdernr.text = order.orderNr;
        this.detailsCompany.text = order.company;
        this.detailsAddress.text = order.address;
        this.detailsCity.text = order.city;
        this.detailsZip.text = order.zip;
        this.detailsProvince.text = order.province;
        this.detailsCountry.text = order.country;
        this.detailsEmail.text = order.email;
        this.detailsPhone.text = order.phone;
        this.detailsDate.text = order.dateOrdered;
        this.detailsShipment.text = order.shipment;
        this.detailsPayment.text = order.payment;
    }
}
