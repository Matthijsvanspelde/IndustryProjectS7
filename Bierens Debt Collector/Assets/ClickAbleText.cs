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
    [SerializeField] private PlayerValidation playervalidation;
    public void OnPointerClick()
    {
        Vector3 mousepos = new Vector3(Input.mousePosition.y, Input.mousePosition.x);
        int linkIndex = TMP_TextUtilities.FindIntersectingLink(text,RenderTextureInteraction.mousePos , camera);
        if (linkIndex != -1)
        {
            TMP_LinkInfo linkInfo = text.textInfo.linkInfo[linkIndex];
            playervalidation.ValidationListPlayer.Add(linkInfo.GetLinkID());
            GameController.instance.CheckValidation();
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        int linkIndex = TMP_TextUtilities.FindIntersectingLink(text, Input.mousePosition, camera);

        if (linkIndex != -1)
        {
            TMP_LinkInfo linkInfo = text.textInfo.linkInfo[linkIndex];
        }
    }
}
