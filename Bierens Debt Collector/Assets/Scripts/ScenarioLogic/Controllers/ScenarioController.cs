using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioController : MonoBehaviour
{
    [SerializeField] private List<StoryScriptableObject> scenarioStartObjects;
    [SerializeField] private MailController mailController;

    private int stressLevel;
    private int levelsCompleted;

    public List<StoryScriptableObject> StartObjectsList()
    {
        return scenarioStartObjects;
    }

    public StoryScriptableObject StartScenario(int scenarioID)
    {
        return scenarioStartObjects[scenarioID];
    }

    public void CreateMail(StoryScriptableObject storyScriptableObject)
    {
        mailController.CreateStoryMail(storyScriptableObject);
    }

    

    public void ResponseDebet()
    {

    }

}
