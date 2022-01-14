using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DatabaseController : MonoBehaviour
{
    public OrderController orderController;
    public GameObject orderDetailWindow;

    [SerializeField] private Transform content;
    [SerializeField] private GameObject prefabRow;

    void Start()
    {
        List<Order> rowList = orderController.getFirstOrderList();
        
        foreach (var row in rowList)
        {
            prefabRow.GetComponent<RowDisplay>().orderScriptable = row;
            //prefabRow.GetComponent<RowDisplay>().createRow();
            Instantiate(prefabRow, content);
        }
        //openOrderDetails(rowList[1]);
    }

    public void openOrderDetails(Order order)
    {
        orderDetailWindow.GetComponent<OrderDetailDisplay>().showOrderDetails(orderDetailWindow, order);
    }
}
