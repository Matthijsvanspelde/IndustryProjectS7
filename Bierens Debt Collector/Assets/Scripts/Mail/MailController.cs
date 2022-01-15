using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailController : MonoBehaviour
{
    [SerializeField] private MailView mailView;
    //we need a list of the story.
    public void CreateStoryMail(StoryScriptableObject storyScriptableObject)
    {
        MailModel mail = new MailModel(storyScriptableObject.mailHeader, storyScriptableObject.mailTextBox);
        mailView.CreateNewMail(mail);
        mailView.CreateNewMail(mail);
    }

    public void PayNowResponse()
    {

    }
    public void ConfrontationResponse()
    {
        //start
    }

    public void CallBierensResponse()
    {
        //start story Bierens
    }


}
