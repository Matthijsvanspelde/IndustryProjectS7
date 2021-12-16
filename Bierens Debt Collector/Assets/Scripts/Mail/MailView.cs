using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MailView : MonoBehaviour
{


    [SerializeField] private GameObject mailButtonPrefab;
    [SerializeField] private TextMeshProUGUI mailText;
    [SerializeField] private Transform MailParant;
    [SerializeField] private GameObject responseWindow;
    Dictionary<GameObject, MailModel> mailDictonary = new Dictionary<GameObject, MailModel>();
    ResponseCode respondCode;

    public void Start()
    {
        respondCode = new ResponseCode();
        CreateNewMail(new MailModel("This is A TestMail", "testText"));
        CreateNewMail(new MailModel("Greetings agian", "this is a greetings mail to you."));
    }

    public void CreateNewMail(MailModel mailModel)
    {
        GameObject mailObject = Instantiate(mailButtonPrefab);
        mailObject.GetComponentInChildren<TextMeshProUGUI>().text = mailModel.Header;
        mailObject.GetComponent<Button>().onClick.AddListener( delegate { OpenMail(mailObject); });
        mailObject.transform.SetParent(MailParant);
        mailObject.transform.localScale = new Vector3(1, 1, 1);
        mailDictonary.Add(mailObject, mailModel);
    }

    void OpenMail(GameObject mailObject)
    {
        MailModel mailModel = mailDictonary[mailObject];
        Debug.Log("You Have Mail");
        mailText.SetText(mailModel.MailText);
    }
    
    public void OpenResponseWindow()
    {
        responseWindow.SetActive(true);
    }

    public void ResponseMailBtn(ResponseCode response)
    {
        switch(response.response)
        {
            case ResponseCode.SendResponse.PAYNOW:
                break;
            case ResponseCode.SendResponse.CONFRONTATION:
                break;
            case ResponseCode.SendResponse.CALLBIERENS:
                break;
            case ResponseCode.SendResponse.RESEARCHCONFRONTATION:
                break;
        }
    }
}
