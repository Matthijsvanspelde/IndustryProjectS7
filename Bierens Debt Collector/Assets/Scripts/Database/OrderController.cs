using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderController : MonoBehaviour
{
    public Order order1;
    public Order order2;
    public Order order3;
    public Order order4;

    public List<Order> getFirstOrderList()
    {
        List<Order> firstlist = new List<Order>();
        firstlist.Add(order1);
        firstlist.Add(order2);
        firstlist.Add(order3);
        firstlist.Add(order4);

        return firstlist;
    }    
}
