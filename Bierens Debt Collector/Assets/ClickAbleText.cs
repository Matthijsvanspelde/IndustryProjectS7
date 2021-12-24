using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ClickAbleText : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private TextMeshProUGUI text;
    public void OnPointerClick(PointerEventData eventData)
    {

        int linkIndex = TMP_TextUtilities.FindIntersectingLink(text, Input.mousePosition, null);
        Debug.Log(linkIndex);
        if (linkIndex != -1)
        { // was a link clicked?
            TMP_LinkInfo linkInfo = text.textInfo.linkInfo[linkIndex];
            Debug.Log(linkInfo.GetLinkID());
            // open the link id as a url, which is the metadata we added in the text field
           // Application.OpenURL(linkInfo.GetLinkID());
        }
    }
}
