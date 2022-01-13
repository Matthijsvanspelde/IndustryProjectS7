using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseController : MonoBehaviour
{
    [SerializeField] private List<GameObject> dbRows;
    [SerializeField] private Transform content;

    void Start()
    {
        foreach (var row in dbRows)
        {
            Instantiate(row, content);
        }
    }
}
