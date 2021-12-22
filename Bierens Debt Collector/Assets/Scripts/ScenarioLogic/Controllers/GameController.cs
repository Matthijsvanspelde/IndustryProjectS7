using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private ScenarioController ScenarioController;
    [SerializeField] private MailController mailController;

    public void LoadScenario(int index)
    {
        mailController.CreateStoryMail(ScenarioController.StartScenario(index));
    }
    public void NextStoryPart(StoryScriptableObject storyScriptableObject)
    {
        mailController.CreateStoryMail(storyScriptableObject);
    }
}
