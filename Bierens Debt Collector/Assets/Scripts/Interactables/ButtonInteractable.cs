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
        gameObject.GetComponent<Button>().onClick.Invoke();
    }
}
