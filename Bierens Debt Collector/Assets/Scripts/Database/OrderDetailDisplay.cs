using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderDetailDisplay : MonoBehaviour
{
    public Order orderScriptable;

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
    public Text detailTotal;

    [SerializeField] private Transform content;
    [SerializeField] private GameObject prefabRow;
    private List<GameObject> orderObject = new List<GameObject>();
    void Start()
    {

    }

    public void showOrderDetails(GameObject window, Order order)
    {
        for (int i = 0; i < orderObject.Count; i++)
        {
            Destroy(orderObject[i]);
        }
        orderObject.Clear();
        window.SetActive(true);
        orderScriptable = order;

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
        detailTotal.text = orderScriptable.total;

        foreach (var row in orderScriptable.items)
        {
            prefabRow.GetComponent<ItemDisplay>().itemScriptable = row;
            //prefabRow.GetComponent<RowDisplay>().createRow();
            GameObject newOrder = Instantiate(prefabRow, content);
            orderObject.Add(newOrder);
        }
    }
}
