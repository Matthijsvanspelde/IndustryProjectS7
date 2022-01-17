using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailController : MonoBehaviour
{
    [SerializeField] private MailView mailView;
    [SerializeField] private GameController gameController;

    //we need a list of the story.
    public void CreateStoryMail(StoryScriptableObject storyScriptableObject)
    {
        MailModel mail = new MailModel(storyScriptableObject.mailHeader, storyScriptableObject.mailTextBox);
        mailView.CreateNewMail(mail);
    }

    public void PayNowResponse()
    {
        gameController.ResponseDebet(GameController.TypeResopnse.Pay);
    }
    public void ConfrontationResponse()
    {
        //start
        gameController.ResponseDebet(GameController.TypeResopnse.Confront);
    }

    public void CallBierensResponse()
    {
        gameController.ResponseDebet(GameController.TypeResopnse.CallBierens);
        //start story Bierens
    }
    public void MemoryResponseResponse()
    {
        gameController.ResponseDebet(GameController.TypeResopnse.SendMail);
        //start story Bierens
    }

}
