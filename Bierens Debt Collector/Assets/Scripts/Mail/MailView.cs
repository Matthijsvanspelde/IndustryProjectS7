using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MailView : MonoBehaviour
{


    [SerializeField] private GameObject mailButtonPrefab;
    [SerializeField] private TextMeshProUGUI mailText;
    [SerializeField] private Transform MailParent;
    [SerializeField] private GameObject responseWindow;
    Dictionary<GameObject, MailModel> mailDictonary = new Dictionary<GameObject, MailModel>();
    ResponseCode respondCode;

    [SerializeField] private Color32 selectedColor;
    private GameObject selectedMail;

    public void Start()
    {
        respondCode = new ResponseCode();
    }

    public void CreateNewMail(MailModel mailModel)
    {
        GameObject mailObject = Instantiate(mailButtonPrefab);
        mailObject.GetComponentInChildren<TextMeshProUGUI>().text = mailModel.Header;
        mailObject.GetComponent<Button>().onClick.AddListener( delegate { OpenMail(mailObject); });
    
        mailObject.transform.SetParent(MailParent);
        mailObject.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        mailObject.transform.localScale = new Vector3(1, 1, 1);
     
        mailDictonary.Add(mailObject, mailModel);
    }

    void OpenMail(GameObject mailObject)
    {
        if (selectedMail != null)
        {
            selectedMail.GetComponent<Image>().color = Color.white;
        }       
        selectedMail = mailObject;
        selectedMail.GetComponent<Image>().color = selectedColor;

        MailModel mailModel = mailDictonary[mailObject];
        Debug.Log("You Have Mail");
        mailText.SetText(mailModel.MailText);
    }
    
    public void OpenResponseWindow()
    {
        responseWindow.SetActive(true);
    }
}
