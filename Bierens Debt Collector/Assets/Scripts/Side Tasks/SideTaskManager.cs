using System.Collections.Generic;
using UnityEngine;

public class SideTaskManager : MonoBehaviour
{
    [SerializeField] private List<SideTask> sideTasks;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            foreach (var sideTask in sideTasks)
            {
                sideTask.StartTask();
            }
        }
    }
}
