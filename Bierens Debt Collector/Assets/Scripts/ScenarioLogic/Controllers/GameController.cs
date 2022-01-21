using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private ScenarioController ScenarioController;
    [SerializeField] private MailController mailController;
    [SerializeField] private List<GameObject> apps;
    [SerializeField] private ValidationController validationController;
    [SerializeField] private Animator cameraAnimation;
    [SerializeField] private Animator pcAnimation;
    [SerializeField] private PlayerValidation playerValidation;
    [SerializeField] private GameObject menu;
    [SerializeField] private List<GameObject> sites;

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
        for (int i =0; i<apps.Count-2; i++)
        {
            apps[i].SetActive(true);
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

    public void FadeToMenu()
    {
        StartCoroutine(delayBeforeGameEnd());
    }

    private void DisableApps()
    {
        foreach(GameObject app in apps)
        {
            app.SetActive(false);
        }
    }

    private void ResetBrowser()
    {
        for(int i=0; i<sites.Count-1; i++)
        {
            if (i == 0)
            {
                sites[i].SetActive(true);
            }
            else
            {
                sites[i].SetActive(false);
            }
        }
    }
    private IEnumerator delayBeforeGameEnd()
    {
        yield return new WaitForSecondsRealtime(5f);
        cameraAnimation.SetTrigger("EndGame");
        DisableApps();
        ResetBrowser();
        pcAnimation.SetTrigger("Close");
        menu.SetActive(true);
    }
}
