using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DatabaseController : MonoBehaviour
{
    public OrderController orderController;
    public GameObject orderDetailWindow;

    public GameObject testRow;

    [SerializeField] private Transform content;
    [SerializeField] private GameObject prefabRow;

    private List<GameObject> objects = new List<GameObject>();
    void Start()
    {
        List<Order> rowList = orderController.getFirstOrderList();

        foreach (var row in rowList)
        {
            GameObject obj= Instantiate(prefabRow, content);
            obj.GetComponent<RowDisplay>().orderScriptable = row;
            obj.GetComponent<RowDisplay>().Setbutton(this);
            objects.Add(obj);
        }
    }

    public void openOrderDetails(GameObject order)
    {
        orderDetailWindow.GetComponent<OrderDetailDisplay>().showOrderDetails(orderDetailWindow, order.GetComponent<RowDisplay>().orderScriptable);
    }
}
