using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private ScenarioController ScenarioController;
    [SerializeField] private MailController mailController;
    [SerializeField] private List<GameObject> apps;
    [SerializeField] private ValidationController validationController;
    [SerializeField] private PlayerValidation playerValidation;
    private StoryScriptableObject currentStory;
    public static GameController instance { get; set; }
    public StoryScriptableObject CurrentStory { get => currentStory; set => currentStory = value; }

    public enum TypeResopnse { Pay, Confront, SendMail, CallBierens }

    private void Start()
    {
        if(instance==null)
        {
            instance = this;
        }
        foreach (var app in apps)
        {
            app.SetActive(true);
        }
    }
    public void CheckValidation()
    {
        validationController.Validate(currentStory.validation, playerValidation);
    }

    public List<StoryScriptableObject> GetStoryScriptableObjects()
    {

        return ScenarioController.StartObjectsList();
    }


    public void LoadScenario(int index)
    {
        CurrentStory = ScenarioController.StartScenario(index);
        mailController.CreateStoryMail(CurrentStory);
        validationController.CheckOpen(CurrentStory.validation);
    }
    public void NextStoryPart(StoryScriptableObject storyScriptableObject)
    {
        mailController.CreateStoryMail(storyScriptableObject);
        validationController.CheckOpen(storyScriptableObject.validation);
    }

    public void ResponseDebet(TypeResopnse resopnse)
    {
        switch (resopnse)
        {
            case TypeResopnse.Pay:
                CurrentStory = CurrentStory.confrontationResponse;
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
