using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderController : MonoBehaviour
{
    Order order;
    [SerializeField] GameObject orderRowPrefab, orderList, detailWindow;

    public GameObject createOrderRow(Order order)
    {
        GameObject newRow = Instantiate(orderRowPrefab, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        newRow.GetComponent<Row>().fillItemRow(order, detailWindow);

        return newRow;
    }

}
