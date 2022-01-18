using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;

public class ClickAbleText : MonoBehaviour,IPointerDownHandler
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private Camera camera;
    public void OnPointerClick()
    {
        Debug.Log("start X: "+text.rectTransform.rect.x +" end X:"+ (text.rectTransform.rect.x+text.rectTransform.rect.width));
        Debug.Log("start Y: " + text.rectTransform.rect.y + " end Y:" + (text.rectTransform.rect.y + text.rectTransform.rect.height));

        Debug.Log("MousePos "+Input.mousePosition);
        int linkIndex = TMP_TextUtilities.FindIntersectingLink(text, Input.mousePosition, camera);
        Debug.Log(linkIndex);
        if (linkIndex != -1)
        {
            TMP_LinkInfo linkInfo = text.textInfo.linkInfo[linkIndex];
            Debug.Log(linkInfo.GetLinkID());
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("start X: " + text.rectTransform.rect.x + " end X:" + (text.rectTransform.rect.x + text.rectTransform.rect.width));
        Debug.Log("start Y: " + text.rectTransform.rect.y + " end Y:" + (text.rectTransform.rect.y + text.rectTransform.rect.height));

        Debug.Log(Input.mousePosition);
        int linkIndex = TMP_TextUtilities.FindIntersectingLink(text, Input.mousePosition, camera);
        Debug.Log(linkIndex);
        if (linkIndex != -1)
        {
            TMP_LinkInfo linkInfo = text.textInfo.linkInfo[linkIndex];
            Debug.Log(linkInfo.GetLinkID());
        }
    }
}
