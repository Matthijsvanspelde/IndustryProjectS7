using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailController : MonoBehaviour
{
    [SerializeField] private MailView mailView;
    //we need a list of the story.
    void CreateStoryMail()
    {
        MailModel mail = new MailModel(".", ".");
        mailView.CreateNewMail(mail);
    }

  public void PayNowResponse()
    {

    }
    public void ConfrontationResponse()
    {

    }

    public void CallBierensResponse()
    {

    }


}
