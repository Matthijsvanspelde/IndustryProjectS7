using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupSideTask : SideTask
{
    [SerializeField] private List<GameObject> popups;
    
    public override void StartTask()
    {
        StartCoroutine(SpawnOverTime(1));
    }

    private IEnumerator SpawnOverTime(float duration)
    {
        foreach (var popup in popups)
        {
            yield return new WaitForSeconds(duration);
            Instantiate(popup, transform);
        }
    }
}

