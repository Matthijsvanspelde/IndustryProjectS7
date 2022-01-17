using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private ScenarioController ScenarioController;
    [SerializeField] private MailController mailController;
    [SerializeField] private List<GameObject> apps;
    [SerializeField] private ValidationController validationController;
    private StoryScriptableObject currentStory;

    public StoryScriptableObject CurrentStory { get => currentStory; set => currentStory = value; }

    public enum TypeResopnse { Pay, Confront, SendMail, CallBierens }

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
        CurrentStory = ScenarioController.StartScenario(index);
        mailController.CreateStoryMail(CurrentStory);
    }
    public void NextStoryPart(StoryScriptableObject storyScriptableObject)
    {
        mailController.CreateStoryMail(storyScriptableObject);
    }

    public void ResponseDebet(TypeResopnse resopnse)
    {
        switch (resopnse)
        {
            case TypeResopnse.Pay:
                CurrentStory = CurrentStory.SendMemoryMail;
                validationController.DeactiveButton();
                NextStoryPart(CurrentStory);
                break;
            case TypeResopnse.SendMail:
                CurrentStory = CurrentStory.SendMemoryMail;
                validationController.DeactiveButton();
                NextStoryPart(CurrentStory);
                break;
            case TypeResopnse.Confront:
                CurrentStory = CurrentStory.confrontationResponse;
                validationController.DeactiveButton();
                NextStoryPart(CurrentStory);
                break;
            case TypeResopnse.CallBierens:
                CurrentStory = CurrentStory.CallBierensResponse;
                validationController.DeactiveButton();
                NextStoryPart(CurrentStory);
                break;
        }
    }
}
