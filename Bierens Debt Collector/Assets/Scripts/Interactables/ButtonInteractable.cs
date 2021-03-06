using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInteractable : Interactable
{
    public override void HideToolTip()
    {
        throw new System.NotImplementedException();
    }

    public override void ShowToolTip()
    {
        throw new System.NotImplementedException();
    }
    public override void Interact()
    {
        if (gameObject.GetComponent<Button>() != null)
        {
            gameObject.GetComponent<Button>().onClick.Invoke();
        }
        if(gameObject.GetComponent<InputField>()!=null)
        {
            gameObject.GetComponent<InputField>().ActivateInputField();
        }
        if (gameObject.GetComponent<ClickAbleText>() != null)
        {
            gameObject.GetComponent<ClickAbleText>().OnPointerClick();
        }
    }
}
