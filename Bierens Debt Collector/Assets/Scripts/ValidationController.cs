using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValidationController : MonoBehaviour
{

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
            ActiveButton();
        }
    }

    void ActiveButton()
    {

    }

    void DeactiveButton()
    {

    }
}
