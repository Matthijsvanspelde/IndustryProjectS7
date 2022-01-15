using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private ScenarioController ScenarioController;
    [SerializeField] private MailController mailController;
    [SerializeField] private List<GameObject> apps;

    private void Start()
    {
        foreach (var app in apps)
        {
            app.SetActive(true);
        }
    }

    public List<StoryScriptableObject> GetStoryScriptableObjects()
    {
        return ScenarioController.StartObjectsList();
    }


    public void LoadScenario(int index)
    {
        mailController.CreateStoryMail(ScenarioController.StartScenario(index));
    }
    public void NextStoryPart(StoryScriptableObject storyScriptableObject)
    {
        mailController.CreateStoryMail(storyScriptableObject);
    }
}
