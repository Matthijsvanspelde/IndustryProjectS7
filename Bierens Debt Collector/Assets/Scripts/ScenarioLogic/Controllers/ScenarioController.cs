using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioController : MonoBehaviour
{
    [SerializeField] private List<ScenarioScriptableObject> scenarioStartObjects;
    private int stressLevel;
    private int levelsCompleted;

    public ScenarioScriptableObject StartScenario(int scenarioID)
    {
        return scenarioStartObjects[scenarioID];
    }
}
