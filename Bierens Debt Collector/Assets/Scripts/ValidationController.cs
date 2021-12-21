using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValidationController : MonoBehaviour
{
    [SerializeField] private GameObject conforntButton, sendMailButton,callBierens;
    public void Validate(ValidationScriptableObject validation,PlayerValidation playerValidation)
    {
        int checkValidate = validation.ValidationText.Count;
        for (int i = 0; i < playerValidation.ValidationListPlayer.Count; i++)
        {
            for (int j = 0; j < validation.ValidationText.Count; j++)
            {
                if(playerValidation.ValidationListPlayer[i]==validation.ValidationText[j])
                {
                    checkValidate++;
                }
            }
        }
        if(checkValidate>=validation.ValidationText.Count)
        {
            ActiveButton(validation);
        }
    }

    void ActiveButton(ValidationScriptableObject validation)
    {
        if(validation.OpenButtonsCallBierens)
        {
            callBierens.SetActive(true);
        }
        if(validation.OpenButtonsConforntation)
        {
            conforntButton.SetActive(true);
        }
        if(validation.OpenButtonfoundMail)
        {
            sendMailButton.SetActive(true);
        }
    }

    void DeactiveButton()
    {
        sendMailButton.SetActive(false);
        conforntButton.SetActive(false);
    }
}
