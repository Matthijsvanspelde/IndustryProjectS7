using System.Collections.Generic;
using UnityEngine;

public class OrderController : MonoBehaviour
{
    public List<Order> orders;

    public List<Order> getFirstOrderList()
    {
        List<Order> firstlist = orders;
        return firstlist;
    }    
}
